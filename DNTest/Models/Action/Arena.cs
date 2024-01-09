using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Models.Dtos;
using Models.Interfaces;
using Models.ModelClasses;

namespace Models.Action
{
    public class Arena
    {
        public RoundLogDto[] Fight(Player player, Monster monster)
        {
            var rounds = new Queue<RoundLogDto>();
            var currentRound = new RoundLog();
            var roundNumber = 1;
            do
            {
                currentRound = Round(roundNumber, player, monster, out var logDto);
                rounds.Enqueue(logDto);
                roundNumber++;
            } while (currentRound.Player.HitPoints > 0 && currentRound.Monster.HitPoints > 0);
            return rounds.ToArray();
        }

        private RoundLog Round(int number, Player player, Monster monster, out RoundLogDto dto)
        {
            var logDto = new RoundLogDto()
            {
                MonsterName = monster.Name,
                PlayerName = player.Name,
                Number = number,
                PlayerAC = player.AC,
                MonsterAC = monster.AC
            };
            var log = new RoundLog()
            {
                Monster = monster,
                Player = player
            };
            var playerDamage = Attack(player, monster, out var playerDiceRoll, out var playerDamageDto, out var isPlayerAttack);
            log.Monster.HitPoints -= playerDamage;
            logDto.PlayerDiceRoll = playerDiceRoll;
            logDto.PlayerDamage = playerDamageDto;
            logDto.IsPlayerDoDamage = isPlayerAttack;
            logDto.MonsterHP = log.Monster.HitPoints;
            logDto.PlayerHP = log.Player.HitPoints;

            if (log.Monster.HitPoints <= 0)
            {
                dto = logDto;
                return log;
            }

            var mosterDamage = Attack(monster, player, out var monsterDiceRoll, out var monsterDamageDto, out var isMonsterAttack);
            log.Player.HitPoints -= mosterDamage;

            logDto.PlayerHP = log.Player.HitPoints;
            logDto.MonsterHP = log.Monster.HitPoints;
            logDto.MonsterDiceRoll = monsterDiceRoll;
            logDto.MonsterDamage = monsterDamageDto;
            logDto.IsMonsterDoDamage = isMonsterAttack;

            dto = logDto;
            return log;
        }

        private int Attack(IActor actor, IActor enemy, out int diceRoll, out int damageDto, out bool isAttack)
        {
            var actorRollResult = DiceRoll();
            diceRoll = actorRollResult.Item1;
            if (actorRollResult.Item2 && actorRollResult.Item1 > enemy.AC)
            {
                var damage = 0;
                for (var i = 0; i < actor.AttackPerRound; i++)
                {
                    damage += DiceRollDamage(actor);
                }
                var actorDamage = damage + actor.AttackModifier + actor.DamageModifier;
                if (actorRollResult.Item3)
                {
                    actorDamage *= 2;
                }
                damageDto = actorDamage;
                isAttack = true;
                return actorDamage;
            }
            damageDto = 0;
            isAttack = false;
            return 0;
        }

        private int DiceRollDamage(IActor actor)
        {
            var damage = actor.Damage.Split('d');
            var count = int.Parse(damage[0]);
            var maxDamage = int.Parse(damage[1]);
            var actualDamage = 0;
            var random = new Random();
            for (var i = 0; i < count; i++)
            {
                actualDamage += random.Next(maxDamage + 1);
            }
            return actualDamage;
        }

        private (int, bool, bool) DiceRoll()
        {
            var maxDamage = 20;
            var random = new Random();
            var result = random.Next(maxDamage + 1);

            if (result == 1 && maxDamage == 20)
            {
                return (result, false, false);
            }
            if (result == 20 && maxDamage == 20)
            {
                return (result, true, true);
            }
            return (result, true, false);
        }
    }
}
