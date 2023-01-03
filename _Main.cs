using BigDLL4221.Models;
using BigDLL4221.Utils;
using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using UnityEngine;
using LOR_DiceSystem;

namespace AphoBoundaryOfDeathAlts
{
    public class AphoBoundaryOfDeathAlts
    {
        public static string PackageId = "AphoBoundaryOfDeathAlts";
        public static string Path;
    }
    public class AphoBoundaryOfDeathAltsInit : ModInitializer
    {
        public override void OnInitializeMod()
        {
            OnInitParameters();
            ArtUtil.GetArtWorks(new DirectoryInfo(AphoBoundaryOfDeathAlts.Path + "/ArtWork"));
            ArtUtil.GetCardArtWorks(new DirectoryInfo(AphoBoundaryOfDeathAlts.Path + "/CardArtWork"));
            ArtUtil.PreLoadBufIcons();
            CardUtil.ChangeCardItem(ItemXmlDataList.instance, AphoBoundaryOfDeathAlts.PackageId);
            KeypageUtil.ChangeKeypageItem(BookXmlList.Instance, AphoBoundaryOfDeathAlts.PackageId);
            PassiveUtil.ChangePassiveItem(AphoBoundaryOfDeathAlts.PackageId);
            LocalizeUtil.AddGlobalLocalize(AphoBoundaryOfDeathAlts.PackageId);
            LocalizeUtil.RemoveError();
            CardUtil.InitKeywordsList(new List<Assembly> { Assembly.GetExecutingAssembly() });
            ArtUtil.InitCustomEffects(new List<Assembly> { Assembly.GetExecutingAssembly() });
        }
        private static void OnInitParameters()
        {
            ModParameters.PackageIds.Add(AphoBoundaryOfDeathAlts.PackageId);
            AphoBoundaryOfDeathAlts.Path = Path.GetDirectoryName(Uri.UnescapeDataString(new UriBuilder(Assembly.GetExecutingAssembly().CodeBase).Path));
            ModParameters.Path.Add(AphoBoundaryOfDeathAlts.PackageId, AphoBoundaryOfDeathAlts.Path);
            OnInitRewards();
            OnInitCards();
        }
        private static void OnInitRewards()
        {
            ModParameters.StartUpRewardOptions.Add(new RewardOptions(cards: new Dictionary<LorId, int>
            {
                { new LorId(AphoBoundaryOfDeathAlts.PackageId, 1), 99 },
                { new LorId(AphoBoundaryOfDeathAlts.PackageId, 2), 99 },
                { new LorId(AphoBoundaryOfDeathAlts.PackageId, 3), 99 },
                { new LorId(AphoBoundaryOfDeathAlts.PackageId, 4), 99 },
                { new LorId(AphoBoundaryOfDeathAlts.PackageId, 5), 99 },
                { new LorId(AphoBoundaryOfDeathAlts.PackageId, 6), 99 },
                { new LorId(AphoBoundaryOfDeathAlts.PackageId, 7), 99 },
                { new LorId(AphoBoundaryOfDeathAlts.PackageId, 8), 99 },
                { new LorId(AphoBoundaryOfDeathAlts.PackageId, 9), 99 },
                { new LorId(AphoBoundaryOfDeathAlts.PackageId, 10), 99 },
                { new LorId(AphoBoundaryOfDeathAlts.PackageId, 11), 99 },
                { new LorId(AphoBoundaryOfDeathAlts.PackageId, 12), 99 },
                { new LorId(AphoBoundaryOfDeathAlts.PackageId, 13), 99 },
                { new LorId(AphoBoundaryOfDeathAlts.PackageId, 14), 99 },
                { new LorId(AphoBoundaryOfDeathAlts.PackageId, 15), 99 },
                { new LorId(AphoBoundaryOfDeathAlts.PackageId, 16), 99 },
                { new LorId(AphoBoundaryOfDeathAlts.PackageId, 17), 99 },
                { new LorId(AphoBoundaryOfDeathAlts.PackageId, 18), 99 },
                { new LorId(AphoBoundaryOfDeathAlts.PackageId, 19), 99 },
                { new LorId(AphoBoundaryOfDeathAlts.PackageId, 20), 99 },
                { new LorId(AphoBoundaryOfDeathAlts.PackageId, 21), 99 },
                { new LorId(AphoBoundaryOfDeathAlts.PackageId, 22), 99 },
                { new LorId(AphoBoundaryOfDeathAlts.PackageId, 23), 99 },
                { new LorId(AphoBoundaryOfDeathAlts.PackageId, 24), 99 },
                { new LorId(AphoBoundaryOfDeathAlts.PackageId, 25), 99 },
                { new LorId(AphoBoundaryOfDeathAlts.PackageId, 26), 99 },
                { new LorId(AphoBoundaryOfDeathAlts.PackageId, 27), 99 },
                { new LorId(AphoBoundaryOfDeathAlts.PackageId, 28), 99 },
                { new LorId(AphoBoundaryOfDeathAlts.PackageId, 29), 99 },
                { new LorId(AphoBoundaryOfDeathAlts.PackageId, 30), 99 },
                { new LorId(AphoBoundaryOfDeathAlts.PackageId, 31), 99 },
                //skip 32, that's unity bod's extra die
            }));
        }
        private static void OnInitCards()
        {
            Color bodred = new Color(0.4f, 0.14f, 0.14f), pbgreen = new Color(0.176f, 0.392f, 0.137f), odagold = new Color(0.745f, 0.639f, 0.267f);
            ModParameters.CardOptions.Add(AphoBoundaryOfDeathAlts.PackageId, new List<CardOptions>
            {
                new CardOptions(1, cardColorOptions: new CardColorOptions(bodred, rightFrame: "Apho_BoundaryOfDeath_RightPage", useHSVFilter: false, customIconColor: new Color(0.353f, 0.196f, 0.549f), iconColor: HSVColors.Purple)),
                new CardOptions(2, cardColorOptions: new CardColorOptions(bodred, rightFrame: "Apho_BoundaryOfDeath_RightPage", useHSVFilter: false, customIconColor: odagold)),
                new CardOptions(3, cardColorOptions: new CardColorOptions(bodred, rightFrame: "Apho_BoundaryOfDeath_RightPage", useHSVFilter: false, customIconColor: odagold)),
                new CardOptions(4, cardColorOptions: new CardColorOptions(bodred, rightFrame: "Apho_BoundaryOfDeath_RightPage", useHSVFilter: false, customIconColor: odagold)),
                new CardOptions(5, cardColorOptions: new CardColorOptions(bodred, rightFrame: "Apho_BoundaryOfDeath_RightPage", useHSVFilter: false, customIconColor: odagold)),
                new CardOptions(6, cardColorOptions: new CardColorOptions(bodred, rightFrame: "Apho_BoundaryOfDeath_RightPage", useHSVFilter: false, customIconColor: odagold)),
                new CardOptions(7, cardColorOptions: new CardColorOptions(bodred, rightFrame: "Apho_BoundaryOfDeath_RightPage", useHSVFilter: false, customIconColor: odagold)),
                new CardOptions(8, cardColorOptions: new CardColorOptions(bodred, rightFrame: "Apho_BoundaryOfDeath_RightPage", useHSVFilter: false, customIconColor: odagold)),
                new CardOptions(9, cardColorOptions: new CardColorOptions(bodred, rightFrame: "Apho_BoundaryOfDeath_RightPage", useHSVFilter: false, customIconColor: odagold)),
                new CardOptions(10, cardColorOptions: new CardColorOptions(bodred, rightFrame: "Apho_BoundaryOfDeath_RightPage", useHSVFilter: false, customIconColor: odagold)),
                new CardOptions(11, cardColorOptions: new CardColorOptions(bodred, rightFrame: "Apho_BoundaryOfDeath_RightPage", useHSVFilter: false, customIconColor: odagold)),
                new CardOptions(12, cardColorOptions: new CardColorOptions(bodred, rightFrame: "Apho_BoundaryOfDeath_RightPage", useHSVFilter: false, customIconColor: odagold)),
                new CardOptions(13, cardColorOptions: new CardColorOptions(bodred, rightFrame: "Apho_BoundaryOfDeath_RightPage", useHSVFilter: false, customIconColor: odagold)),
                new CardOptions(14, cardColorOptions: new CardColorOptions(bodred, rightFrame: "Apho_BoundaryOfDeath_RightPage", useHSVFilter: false, customIconColor: pbgreen)),
                new CardOptions(15, cardColorOptions: new CardColorOptions(bodred, rightFrame: "Apho_BoundaryOfDeath_RightPage", useHSVFilter: false, customIconColor: pbgreen)),
                new CardOptions(16, cardColorOptions: new CardColorOptions(bodred, rightFrame: "Apho_BoundaryOfDeath_RightPage", useHSVFilter: false, customIconColor: odagold)),
                new CardOptions(17, cardColorOptions: new CardColorOptions(bodred, rightFrame: "Apho_BoundaryOfDeath_RightPage", useHSVFilter: false, customIconColor: odagold)),
                new CardOptions(18, cardColorOptions: new CardColorOptions(bodred, rightFrame: "Apho_BoundaryOfDeath_RightPage", useHSVFilter: false, customIconColor: odagold)),
                new CardOptions(19, cardColorOptions: new CardColorOptions(bodred, rightFrame: "Apho_BoundaryOfDeath_RightPage", useHSVFilter: false, customIconColor: odagold)),
                new CardOptions(20, cardColorOptions: new CardColorOptions(bodred, rightFrame: "Apho_BoundaryOfDeath_RightPage", useHSVFilter: false, customIconColor: odagold)),
                new CardOptions(21, cardColorOptions: new CardColorOptions(bodred, rightFrame: "Apho_BoundaryOfDeath_RightPage", useHSVFilter: false, customIconColor: odagold)),
                new CardOptions(22, cardColorOptions: new CardColorOptions(bodred, rightFrame: "Apho_BoundaryOfDeath_RightPage", useHSVFilter: false, customIconColor: odagold)),
                new CardOptions(23, cardColorOptions: new CardColorOptions(bodred, rightFrame: "Apho_BoundaryOfDeath_RightPage", useHSVFilter: false, customIconColor: odagold)),
                new CardOptions(24, cardColorOptions: new CardColorOptions(bodred, rightFrame: "Apho_BoundaryOfDeath_RightPage", useHSVFilter: false, customIconColor: odagold)),
                new CardOptions(25, cardColorOptions: new CardColorOptions(bodred, rightFrame: "Apho_BoundaryOfDeath_RightPage", useHSVFilter: false, customIconColor: odagold)),
                new CardOptions(26, cardColorOptions: new CardColorOptions(bodred, rightFrame: "Apho_BoundaryOfDeath_RightPage", useHSVFilter: false, customIconColor: odagold)),
                new CardOptions(27, cardColorOptions: new CardColorOptions(bodred, rightFrame: "Apho_BoundaryOfDeath_RightPage", useHSVFilter: false, customIconColor: odagold)),
                new CardOptions(28, cardColorOptions: new CardColorOptions(bodred, rightFrame: "Apho_BoundaryOfDeath_RightPage", useHSVFilter: false, customIconColor: odagold)),
                new CardOptions(29, cardColorOptions: new CardColorOptions(bodred, rightFrame: "Apho_BoundaryOfDeath_RightPage", useHSVFilter: false, customIconColor: odagold)),
                new CardOptions(30, cardColorOptions: new CardColorOptions(bodred, rightFrame: "Apho_BoundaryOfDeath_RightPage", useHSVFilter: false, customIconColor: odagold)),
                new CardOptions(31, cardColorOptions: new CardColorOptions(bodred, rightFrame: "Apho_BoundaryOfDeath_RightPage", useHSVFilter: false, customIconColor: odagold)),
                //skip 32, that's unity bod's extra die

            });
        }
    }

    public class DiceCardAbility_Apho_BoundaryOfDeath_Degraded : DiceCardAbilityBase
    {
        public static string Desc = "If the natural roll is Max, and is 4 or higher, add +34 power";
        public override void OnRollDice()
        {
            if (this.behavior.DiceVanillaValue >= 4 && this.behavior.DiceVanillaValue == this.behavior.GetDiceMax())
            {
                this.behavior.ApplyDiceStatBonus(new DiceStatBonus
                {
                    power = 34
                });
            }
        }
    }
    public class DiceCardAbility_Apho_BoundaryOfDeath_Barrage : DiceCardAbilityBase
    {
        public static string Desc = "If the natural roll is Max, and is 4 or higher, add +14 power. Otherwise, destroy all dice on this page.";
        public override void OnRollDice()
        {
            if (this.behavior.DiceVanillaValue >= 4 && this.behavior.DiceVanillaValue == this.behavior.GetDiceMax())
            {
                this.behavior.ApplyDiceStatBonus(new DiceStatBonus
                {
                    power = 14
                });
            }else
            {
                BattlePlayingCardDataInUnitModel currentDiceAction = base.owner.currentDiceAction;
                if (currentDiceAction == null)
                {
                    return;
                }
                currentDiceAction.DestroyDice(DiceMatch.AllDice, DiceUITiming.AttackAfter);
            }
        }
    }

    public class DiceCardAbility_Apho_BoundaryOfDeath_Mortality : DiceCardAbilityBase
    {
        public static string Desc = "If the natural roll is Max, and is 4 or higher, add +44-444 power\nIf the natural roll is Min, or is 2 or lower, die";
        public override void OnRollDice()
        {
            if (this.behavior.DiceVanillaValue >= 4 && this.behavior.DiceVanillaValue == this.behavior.GetDiceMax())
            {
                int _rng;
                _rng = RandomUtil.Range(44, 444);
                this.behavior.ApplyDiceStatBonus(new DiceStatBonus
                {
                    power = _rng
                });
            }
            if (this.behavior.DiceVanillaValue <= 2 || this.behavior.DiceVanillaValue == this.behavior.GetDiceMin())
            {
                this.owner.Die();
            }

        }
    }
    public class DiceCardSelfAbility_Apho_BoundaryOfDeath_Volatile : DiceCardSelfAbilityBase
    {
        public static string Desc = "[On Use] Types of Offensive dice on this page change to a random type";
        public override void OnUseCard()
        {
            if (this.card.target == null)
            {
                return;
            }
            int _rng;
            _rng = RandomUtil.Range(0, 2);
            List<BehaviourDetail> list = new List<BehaviourDetail>();
            switch (_rng)
            {
                case 0:
                    list.Add(BehaviourDetail.Slash);
                    break;
                case 1:
                    list.Add(BehaviourDetail.Penetrate);
                    break;
                case 2:
                    list.Add(BehaviourDetail.Hit);
                    break;
            }
            BehaviourDetail detail = RandomUtil.SelectOne<BehaviourDetail>(list);
            foreach (BattleDiceBehavior battleDiceBehavior in this.card.GetDiceBehaviorList())
            {
                if (base.IsAttackDice(battleDiceBehavior.behaviourInCard.Detail))
                {
                    battleDiceBehavior.behaviourInCard = battleDiceBehavior.behaviourInCard.Copy();
                    battleDiceBehavior.behaviourInCard.Detail = detail;
                }
            }
        }
    }

    public class DiceCardAbility_Apho_BoundaryOfDeath_Upstanding : DiceCardAbilityBase
    {
        public static string Desc = "If the natural roll is Max, and is 4 or higher, add +14 Power, draw 1 page, and reduce the Cost of all other 'Upstanding Boundary of Deaths' by 1";
        public override string[] Keywords => new string[1] { "DrawCard_Keyword" };
        public override void OnRollDice()
        {
            if (this.behavior.DiceVanillaValue >= 4 && this.behavior.DiceVanillaValue == this.behavior.GetDiceMax())
            {
                this.behavior.ApplyDiceStatBonus(new DiceStatBonus
                {
                    power = 14
                });
                foreach (BattleDiceCardModel item in base.owner.allyCardDetail.GetAllDeck().FindAll((BattleDiceCardModel x) => x != card.card && x.GetID() == new LorId(AphoBoundaryOfDeathAlts.PackageId, 14)))
                {
                    item.GetBufList();
                    item.AddCost(-1);
                }
                base.owner.allyCardDetail.DrawCards(1);
            }
        }
    }
    public class DiceCardSelfAbility_Apho_BoundaryOfDeath_Level : DiceCardSelfAbilityBase
    {
        public override string[] Keywords => new string[2] { "Energy_Keyword", "Bleeding_Keyword" };
    }
    public class DiceCardAbility_Apho_BoundaryOfDeath_LevelDice : DiceCardAbilityBase
    {
        public static string Desc = "If the natural roll is Max, and is 4 or higher, add +14 Power, restore 2 Light, inflict 4 Bleed on hit, and reduce the Cost of all other 'Level Boundary of Deaths' by 1";
        public override string[] Keywords => new string[2] { "Energy_Keyword", "Bleeding_Keyword" };
        private bool _activated;
        public override void OnRollDice()
        {
            if (this.behavior.DiceVanillaValue >= 4 && this.behavior.DiceVanillaValue == this.behavior.GetDiceMax())
            {
                this.behavior.ApplyDiceStatBonus(new DiceStatBonus
                {
                    power = 14
                });
                foreach (BattleDiceCardModel item in base.owner.allyCardDetail.GetAllDeck().FindAll((BattleDiceCardModel x) => x != card.card && x.GetID() == new LorId(AphoBoundaryOfDeathAlts.PackageId, 15)))
                {
                    item.GetBufList();
                    item.AddCost(-1);
                }
                base.owner.cardSlotDetail.RecoverPlayPointByCard(2);
                _activated = true;
            }
            else
            {
                _activated= false;
            }
        }

        public override void OnSucceedAttack(BattleUnitModel target)
        {
            if(_activated == true)
            {
                target?.bufListDetail.AddKeywordBufByCard(KeywordBuf.Bleeding, 4, base.owner);
            }
            _activated = false;
        }
    }
    public class DiceCardAbility_Apho_BoundaryOfDeath_Radiant : DiceCardAbilityBase
    {
        public static string Desc = "If the natural roll is Max, and is 4 or higher, all other allies restore 1-4 Light";
        public override string[] Keywords => new string[1] { "Energy_Keyword" };
        public override void OnRollDice()
        {
            if (this.behavior.DiceVanillaValue >= 4 && this.behavior.DiceVanillaValue == this.behavior.GetDiceMax())
            {
                foreach (BattleUnitModel battleUnitModel in BattleObjectManager.instance.GetAliveList(base.owner.faction))
                {
                    if (battleUnitModel != base.owner)
                    {
                        battleUnitModel.bufListDetail.AddBuf(new BattleUnitBuf_Apho_BoundaryOfDeath_RadiantBuf());
                    }
                }
            }
        }
        public class BattleUnitBuf_Apho_BoundaryOfDeath_RadiantBuf : BattleUnitBuf
        {
            private int _rng;
            public override void OnRoundEnd()
            {
                _rng = RandomUtil.Range(1, 4);
                this._owner.cardSlotDetail.RecoverPlayPointByCard(_rng);
                this.Destroy();
            }
        }
    }
    public class DiceCardAbility_Apho_BoundaryOfDeath_Lock : DiceCardAbilityBase
    {
        public static string Desc = "If the natural roll is Max, and is 4 or higher, add 14 Power, and increase Cost of target's pages whose original Cost is 4 or higher by 4 for the next Scene on hit";
        private bool _activated;
        public override void OnRollDice()
        {
            if (this.behavior.DiceVanillaValue >= 4 && this.behavior.DiceVanillaValue == this.behavior.GetDiceMax())
            {
                this.behavior.ApplyDiceStatBonus(new DiceStatBonus
                {
                    power = 14
                });
                _activated = true;
            }
            else
            {
                _activated = false;
            }

        }
        public override void OnSucceedAttack(BattleUnitModel target)
        {
            if (target != null && _activated == true)
            {
                target.bufListDetail.AddReadyBuf(new BattleUnitBuf_Apho_BoundaryOfDeath_LockBuf());
            }
            _activated = false;
        }
        public class BattleUnitBuf_Apho_BoundaryOfDeath_LockBuf : BattleUnitBuf
        {
            public override int GetCardCostAdder(BattleDiceCardModel card)
            {
                if (card.GetOriginCost() >= 4)
                {
                    return 4;
                }
                return 0;
            }
            public override void OnRoundEnd()
            {
                this.Destroy();
            }
        }
    }

    public class DiceCardAbility_Apho_BoundaryOfDeath_Chain : DiceCardAbilityBase
    {
        public static string Desc = "If the natural roll is Max, and is 4 or higher, add 14 Power, and seal 1-4 Speed dice of target for the next Scene on hit";
        private bool _activated;
        public override void OnRollDice()
        {
            if (this.behavior.DiceVanillaValue >= 4 && this.behavior.DiceVanillaValue == this.behavior.GetDiceMax())
            {
                this.behavior.ApplyDiceStatBonus(new DiceStatBonus
                {
                    power = 14
                });
                _activated = true;
            }
            else
            {
                _activated = false;
            }

        }
        public override void OnSucceedAttack(BattleUnitModel target)
        {
            if (target != null && _activated == true)
            {
                int _rng = RandomUtil.Range(1, 4);
                if (target != null)
                {
                    for (int i = 0; i < _rng; i++)
                    {
                        target.bufListDetail.AddReadyBuf(new BattleUnitBuf_sealTemp());
                    }
                }
                _activated = false;
            }
        }
        
    }

    public class DiceCardSelfAbility_Apho_BoundaryOfDeath_Fairy : DiceCardSelfAbilityBase
    {
        public override string[] Keywords => new string[1] { "BinahFairy" };
    }
    public class DiceCardAbility_Apho_BoundaryOfDeath_FairyDice : DiceCardAbilityBase
    {
        public static string Desc = "If the natural roll is Max, and is 4 or higher, inflict 4-14 Fairy on hit";
        private bool _activated;
        public override void OnRollDice()
        {
            if (this.behavior.DiceVanillaValue >= 4 && this.behavior.DiceVanillaValue == this.behavior.GetDiceMax())
            {
                _activated = true;
            }
            else
            {
                _activated = false;
            }

        }
        public override void OnSucceedAttack(BattleUnitModel target)
        {
            if (target != null && _activated == true)
            {
                int _rng = RandomUtil.Range(4, 14);
                target?.bufListDetail.AddKeywordBufByCard(KeywordBuf.Fairy, _rng, base.owner);
            }
            _activated = false;
        }

    }

    public class DiceCardSelfAbility_Apho_BoundaryOfDeath_Erosion : DiceCardSelfAbilityBase
    {
        public override string[] Keywords => new string[1] { "Decay" };
    }
    public class DiceCardAbility_Apho_BoundaryOfDeath_ErosionDice : DiceCardAbilityBase
    {
        public static string Desc = "If the natural roll is Max, and is 4 or higher, inflict 4-14 Erosion on hit";
        private bool _activated;
        public override void OnRollDice()
        {
            if (this.behavior.DiceVanillaValue >= 4 && this.behavior.DiceVanillaValue == this.behavior.GetDiceMax())
            {
                _activated = true;
            }
            else
            {
                _activated = false;
            }

        }
        public override void OnSucceedAttack(BattleUnitModel target)
        {
            if (target != null && _activated == true)
            {
                int _rng = RandomUtil.Range(4, 14);
                target?.bufListDetail.AddKeywordBufByCard(KeywordBuf.Decay, _rng, base.owner);
            }
            _activated = false;
        }

    }

    public class DiceCardAbility_Apho_BoundaryOfDeath_Reverse : DiceCardAbilityBase
    {
        public static string Desc = "If the natural roll is Min, and is 1 or lower, add +45 power";
        public override void OnRollDice()
        {
            if (this.behavior.DiceVanillaValue <= 1 && this.behavior.DiceVanillaValue == this.behavior.GetDiceMin())
            {
                this.behavior.ApplyDiceStatBonus(new DiceStatBonus
                {
                    power = 45
                });
            }
        }
    }

    public class DiceCardSelfAbility_Apho_BoundaryOfDeath_Red : DiceCardSelfAbilityBase
    {
        public static string Desc = "Dice on this page deal double damage and no stagger damage";
    }
    public class DiceCardAbility_Apho_BoundaryOfDeath_RedDice : DiceCardAbilityBase
    {
        public static string Desc = "If the natural roll is Max, and is 4 or higher, add +45 power";
        public override void OnRollDice()
        {
            if (this.behavior.DiceVanillaValue >= 4 && this.behavior.DiceVanillaValue == this.behavior.GetDiceMax())
            {
                this.behavior.ApplyDiceStatBonus(new DiceStatBonus
                {
                    power = 45
                });
            }
        }
        public override void BeforeGiveDamage()
        {
            this.behavior.ApplyDiceStatBonus(new DiceStatBonus
            {
                dmgRate = 100,
                breakRate = -100,
            });
        }
    }
    public class DiceCardSelfAbility_Apho_BoundaryOfDeath_White : DiceCardSelfAbilityBase
    {
        public static string Desc = "Dice on this page deal no damage and double stagger damage";
    }
    public class DiceCardAbility_Apho_BoundaryOfDeath_WhiteDice : DiceCardAbilityBase
    {
        public static string Desc = "If the natural roll is Max, and is 4 or higher, add +45 power";
        public override void OnRollDice()
        {
            if (this.behavior.DiceVanillaValue >= 4 && this.behavior.DiceVanillaValue == this.behavior.GetDiceMax())
            {
                this.behavior.ApplyDiceStatBonus(new DiceStatBonus
                {
                    power = 45
                });
            }
        }
        public override void BeforeGiveDamage()
        {
            BattlePlayingCardDataInUnitModel card = this.card;
            BattleUnitModel battleUnitModel = (card != null) ? card.target : null;
            if (battleUnitModel == null)
            {
                return;
            }
            this.behavior.ApplyDiceStatBonus(new DiceStatBonus
            {
                dmgRate = -100,
                breakRate = 100,
            });
        }
    }

    public class DiceCardSelfAbility_Apho_BoundaryOfDeath_Black : DiceCardSelfAbilityBase
    {
        public static string Desc = "Dice on this page deal no damage or stagger damage";
    }
    public class DiceCardAbility_Apho_BoundaryOfDeath_BlackDice : DiceCardAbilityBase
    {
        public static string Desc = "If the natural roll is Max, and is 4 or higher, add +45 power\n[On Hit] Deal bonus damage and stagger damage equal to dice roll\n(Ignores resistances)";
        public override void OnRollDice()
        {
            if (this.behavior.DiceVanillaValue >= 4 && this.behavior.DiceVanillaValue == this.behavior.GetDiceMax())
            {
                this.behavior.ApplyDiceStatBonus(new DiceStatBonus
                {
                    power = 45
                });
            }
        }
        public override void BeforeGiveDamage()
        {
            BattlePlayingCardDataInUnitModel card = this.card;
            BattleUnitModel battleUnitModel = (card != null) ? card.target : null;
            if (battleUnitModel == null)
            {
                return;
            }
            this.behavior.ApplyDiceStatBonus(new DiceStatBonus
            {
                dmgRate = -100,
                breakRate = -100,
            });
        }
        public override void OnSucceedAttack()
        {
            int _dmg = this.behavior.DiceResultValue;
            BattleUnitModel target = base.card.target;
            if (target == null)
            {
                return;
            }
            target.TakeDamage(_dmg, DamageType.Card_Ability, base.owner, KeywordBuf.None);
            target.TakeBreakDamage(_dmg, DamageType.Card_Ability, base.owner);
        }
    }
    public class DiceCardSelfAbility_Apho_BoundaryOfDeath_Pale : DiceCardSelfAbilityBase
    {
        public static string Desc = "Dice on this page deal no damage or stagger damage";
    }
    public class DiceCardAbility_Apho_BoundaryOfDeath_PaleDice : DiceCardAbilityBase
    {
        public static string Desc = "If the natural roll is Max, and is 4 or higher, add +45 power\n[On Hit] Deal bonus damage equal to (Dice value x 0.14)% of target's Max HP\n(Ignores resistances)";
        public override void OnRollDice()
        {
            if (this.behavior.DiceVanillaValue >= 4 && this.behavior.DiceVanillaValue == this.behavior.GetDiceMax())
            {
                this.behavior.ApplyDiceStatBonus(new DiceStatBonus
                {
                    power = 45
                });
            }
        }
        public override void BeforeGiveDamage()
        {
            BattlePlayingCardDataInUnitModel card = this.card;
            BattleUnitModel battleUnitModel = (card != null) ? card.target : null;
            if (battleUnitModel == null)
            {
                return;
            }
            this.behavior.ApplyDiceStatBonus(new DiceStatBonus
            {
                dmgRate = -100,
                breakRate = -100,
            });
        }
        public override void OnSucceedAttack()
        {
            
            BattleUnitModel target = base.card.target;
            int _dmg = (int)(this.behavior.DiceResultValue * base.card.target.MaxHp * 0.0014);
            if (target == null)
            {
                return;
            }
            target.TakeDamage(_dmg, DamageType.Card_Ability, base.owner, KeywordBuf.None);
        }
    }

    public class DiceCardAbility_Apho_BoundaryOfDeath_Draw : DiceCardAbilityBase
    {
        public static string Desc = "If the natural roll is Max, and is 4 or higher, add 14 power, and draw 4 pages";
        public override void OnRollDice()
        {
            if (this.behavior.DiceVanillaValue >= 4 && this.behavior.DiceVanillaValue == this.behavior.GetDiceMax())
            {
                this.behavior.ApplyDiceStatBonus(new DiceStatBonus
                {
                    power = 14
                });
                base.owner.allyCardDetail.DrawCards(4);
            }

        }
    }
    public class DiceCardAbility_Apho_BoundaryOfDeath_Deal : DiceCardAbilityBase
    {
        public static string Desc = "If the natural roll is Max, and is 4 or higher, all other allies draw 1 page";
        public override void OnRollDice()
        {
            if (this.behavior.DiceVanillaValue >= 4 && this.behavior.DiceVanillaValue == this.behavior.GetDiceMax())
            {
                foreach (BattleUnitModel battleUnitModel in BattleObjectManager.instance.GetAliveList(base.owner.faction))
                {
                    if (battleUnitModel != base.owner)
                    {
                        battleUnitModel.allyCardDetail.DrawCards(1);
                    }
                }
            }

        }
    }
    public class DiceCardAbility_Apho_BoundaryOfDeath_Charging : DiceCardAbilityBase
    {
        public override string[] Keywords => new string[1] { "WarpCharge" };
        public static string Desc = "If the natural roll is Max, and is 4 or higher, add +34 power, and gain 14 Charge";
        public override void OnRollDice()
        {
            if (this.behavior.DiceVanillaValue >= 4 && this.behavior.DiceVanillaValue == this.behavior.GetDiceMax())
            {
                this.behavior.ApplyDiceStatBonus(new DiceStatBonus
                {
                    power = 34
                });
                base.owner.bufListDetail.AddKeywordBufThisRoundByCard(KeywordBuf.WarpCharge, 14, null);
            }
        }
    }
    public class DiceCardAbility_Apho_BoundaryOfDeath_Powercycle : DiceCardAbilityBase
    {
        public override string[] Keywords => new string[1] { "WarpCharge" };
        public static string Desc = "If the natural roll is Max, and is 4 or higher, add +42 power. Otherwise, spend 4 Charge to recycle this die (Max. 4 times)";
        private int _attempts;
        public override void OnRollDice()
        {
            
            if (this.behavior.DiceVanillaValue >= 4 && this.behavior.DiceVanillaValue == this.behavior.GetDiceMax())
            {
                this.behavior.ApplyDiceStatBonus(new DiceStatBonus
                {
                    power = 42
                });
            }
            else
            {
                BattleUnitBuf_warpCharge battleUnitBuf_warpCharge = base.owner.bufListDetail.GetActivatedBuf(KeywordBuf.WarpCharge) as BattleUnitBuf_warpCharge;
                if (battleUnitBuf_warpCharge != null && battleUnitBuf_warpCharge.stack >= 4 && this._attempts < 4)
                {
                    battleUnitBuf_warpCharge.UseStack(4, true);
                    if (this._attempts == 0)
                    {
                        BehaviourAction_sweeperOnly.movable = true;
                    }
                    if (this._attempts >= 4)
                    {
                        return;
                    }
                    base.ActivateBonusAttackDice();
                    this._attempts++;
                }
            }
        }
    }

    public class DiceCardAbility_Apho_BoundaryOfDeath_Discharge : DiceCardAbilityBase
    {
        public override string[] Keywords => new string[1] { "WarpCharge" };
        public static string Desc = "If the natural roll is Max, and is 4 or higher, spend all Charge to add power equal to 4x the amount spent (Max. 64)";
        public int chargeStack;
        public override void OnRollDice()
        {
            if (this.behavior.DiceVanillaValue >= 4 && this.behavior.DiceVanillaValue == this.behavior.GetDiceMax())
            {
                BattleUnitBuf_warpCharge battleUnitBuf_warpCharge = base.owner.bufListDetail.GetActivatedBuf(KeywordBuf.WarpCharge) as BattleUnitBuf_warpCharge;
                if (battleUnitBuf_warpCharge != null && battleUnitBuf_warpCharge.stack > 0)
                {
                    this.chargeStack = battleUnitBuf_warpCharge.stack;
                    battleUnitBuf_warpCharge.UseStack(battleUnitBuf_warpCharge.stack, true);
                }
                int _bonus = Mathf.Min(this.chargeStack * 4, 64);
                this.behavior.ApplyDiceStatBonus(new DiceStatBonus
                {
                    power = _bonus
                });
            }
        }
    }
    public class DiceCardSelfAbility_Apho_BoundaryOfDeath_Unity : DiceCardSelfAbilityBase
    {
        public static string Desc = "[Unity]\n[Combat Start] For this Scene, all other allies using a Unity page gain a Pierce die (1-4, If the natural roll is Max, and is 4 or higher, add +14 power) on the page (Cannot be stacked)";
        public override bool IsUniteCard
        {
            get
            {
                return true;
            }
        }
        public override void OnStartBattle()
        {
            foreach (BattleUnitModel battleUnitModel in BattleObjectManager.instance.GetAliveList(base.owner.faction))
            {
                if (battleUnitModel != base.owner && !battleUnitModel.bufListDetail.HasBuf<BattleUnitBuf_Apho_BoundaryOfDeath_UnityBuf>())
                {
                    battleUnitModel.bufListDetail.AddBuf(new BattleUnitBuf_Apho_BoundaryOfDeath_UnityBuf());
                }
            }
        }
        public class BattleUnitBuf_Apho_BoundaryOfDeath_UnityBuf : BattleUnitBuf
        {
            public override void OnUseCard(BattlePlayingCardDataInUnitModel card)
            {
                if (card.cardAbility != null && card.cardAbility.IsUniteCard)
                {
                    new BattleDiceBehavior();
                    BattleDiceCardModel battleDiceCardModel = BattleDiceCardModel.CreatePlayingCard(ItemXmlDataList.instance.GetCardItem(new LorId(AphoBoundaryOfDeathAlts.PackageId, 32), false));
                    if (battleDiceCardModel != null)
                    {
                        foreach (BattleDiceBehavior diceBehavior in battleDiceCardModel.CreateDiceCardBehaviorList())
                        {
                            card.AddDice(diceBehavior);
                        }
                    }
                }
            }
            public override void OnRoundEnd()
            {
                this.Destroy();
            }
        }
    }
    public class DiceCardAbility_Apho_BoundaryOfDeath_UnityMainDie : DiceCardAbilityBase
    {
        public static string Desc = "If the natural roll is Max, and is 4 or higher, add +4 power";
        public override void OnRollDice()
        {
            if (this.behavior.DiceVanillaValue >= 4 && this.behavior.DiceVanillaValue == this.behavior.GetDiceMax())
            {
                this.behavior.ApplyDiceStatBonus(new DiceStatBonus
                {
                    power = 4
                });
            }
        }
    }
    public class DiceCardAbility_Apho_BoundaryOfDeath_UnityExtraDie : DiceCardAbilityBase
    {
        public static string Desc = "If the natural roll is Max, and is 4 or higher, add +14 power";
        public override void OnRollDice()
        {
            if (this.behavior.DiceVanillaValue >= 4 && this.behavior.DiceVanillaValue == this.behavior.GetDiceMax())
            {
                this.behavior.ApplyDiceStatBonus(new DiceStatBonus
                {
                    power = 14
                });
            }
        }
    }
}
