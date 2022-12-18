using System;
using System.Collections.Generic;
using UnityEngine;

namespace AphoBoundaryOfDeathAlts
{
    public class BehaviourAction_Apho_BoundaryOfDeath_RangedAnim : BehaviourActionBase
    {
        public override List<RencounterManager.MovingAction> GetMovingAction(ref RencounterManager.ActionAfterBehaviour self, ref RencounterManager.ActionAfterBehaviour opponent)
        {
            List<RencounterManager.MovingAction> list = new List<RencounterManager.MovingAction>();
            int vanillaDiceValue = self.behaviourResultData.vanillaDiceValue;
            int resultDiceMax = self.behaviourResultData.resultDiceMax;
            bool flag = vanillaDiceValue >= 4 && vanillaDiceValue >= resultDiceMax;
            bool flag2 = false;
            if (opponent.behaviourResultData != null)
            {
                flag2 = opponent.behaviourResultData.IsFarAtk();
            }
            if (self.result == Result.Win && self.data.actionType == ActionType.Atk && flag && !flag2)
            {
                RencounterManager.MovingAction movingAction = new RencounterManager.MovingAction(ActionDetail.S1, CharMoveState.None, 30f, false, 0f, 1f);
                movingAction.SetEffectTiming(EffectTiming.PRE, EffectTiming.NONE, EffectTiming.NONE);
                movingAction.customEffectRes = "BorderOfDeath";
                list.Add(movingAction);
                RencounterManager.MovingAction item = new RencounterManager.MovingAction(ActionDetail.S1, CharMoveState.None, 0.2f, false, 1f, 1f);
                list.Add(item);
                RencounterManager.MovingAction movingAction2 = new RencounterManager.MovingAction(ActionDetail.S2, CharMoveState.Stop, 1f, false, 1.5f, 1f);
                movingAction2.SetEffectTiming(EffectTiming.NONE, EffectTiming.PRE, EffectTiming.PRE);
                list.Add(movingAction2);
                opponent.infoList.Add(new RencounterManager.MovingAction(ActionDetail.Damaged, CharMoveState.Stop, 1f, false, 0f, 1f));
                opponent.infoList.Add(new RencounterManager.MovingAction(ActionDetail.Damaged, CharMoveState.Stop, 1f, false, 0f, 1f));
                opponent.infoList.Add(new RencounterManager.MovingAction(ActionDetail.Damaged, CharMoveState.Stop, 1f, false, 1f, 1f));
            }
            else
            {
                list = base.GetMovingAction(ref self, ref opponent);
            }
            return list;
        }
    }
    public class BehaviourAction_Apho_BoundaryOfDeath_SalvoAnim : BehaviourActionBase
    {
        public override List<RencounterManager.MovingAction> GetMovingAction(ref RencounterManager.ActionAfterBehaviour self, ref RencounterManager.ActionAfterBehaviour opponent)
        {
            List<RencounterManager.MovingAction> list = new List<RencounterManager.MovingAction>();
            if (self.result == Result.Win && self.data.actionType == ActionType.Atk)
            {
                RencounterManager.MovingAction movingAction = new RencounterManager.MovingAction(ActionDetail.S1, CharMoveState.None, 0.2f, false, 0f, 0.2f);
                movingAction.SetEffectTiming(EffectTiming.PRE, EffectTiming.NONE, EffectTiming.NONE);
                movingAction.customEffectRes = "BorderOfDeath";
                list.Add(movingAction);
                RencounterManager.MovingAction item = new RencounterManager.MovingAction(ActionDetail.S1, CharMoveState.None, 0.2f, false, 0.2f, 0.2f);
                list.Add(item);
                RencounterManager.MovingAction movingAction2 = new RencounterManager.MovingAction(ActionDetail.S2, CharMoveState.Stop, 0.2f, false, 0.4f, 0.3f);
                movingAction2.SetEffectTiming(EffectTiming.NONE, EffectTiming.PRE, EffectTiming.PRE);
                list.Add(movingAction2);
                opponent.infoList.Add(new RencounterManager.MovingAction(ActionDetail.Damaged, CharMoveState.Stop, 0.2f, false, 0f, 0.2f));
                opponent.infoList.Add(new RencounterManager.MovingAction(ActionDetail.Damaged, CharMoveState.Stop, 0.2f, false, 0f, 0.2f));
                opponent.infoList.Add(new RencounterManager.MovingAction(ActionDetail.Damaged, CharMoveState.Stop, 0.2f, false, 0.2f, 0.2f));
            }
            else
            {
                list = base.GetMovingAction(ref self, ref opponent);
            }
            return list;
        }
    }

    public class BehaviourAction_Apho_BoundaryOfDeath_BarrageAnim : BehaviourActionBase
    {
        public override List<RencounterManager.MovingAction> GetMovingAction(ref RencounterManager.ActionAfterBehaviour self, ref RencounterManager.ActionAfterBehaviour opponent)
        {
            List<RencounterManager.MovingAction> list = new List<RencounterManager.MovingAction>();
            if (self.result == Result.Win && self.data.actionType == ActionType.Atk)
            {
                RencounterManager.MovingAction movingAction = new RencounterManager.MovingAction(ActionDetail.S1, CharMoveState.MoveForward, 0.2f, false, 0f, 0.2f);
                movingAction.SetEffectTiming(EffectTiming.PRE, EffectTiming.NONE, EffectTiming.NONE);
                movingAction.customEffectRes = "BorderOfDeath";
                list.Add(movingAction);
                RencounterManager.MovingAction item = new RencounterManager.MovingAction(ActionDetail.S1, CharMoveState.MoveForward, 0.2f, false, 0.2f, 0.2f);
                list.Add(item);
                RencounterManager.MovingAction movingAction2 = new RencounterManager.MovingAction(ActionDetail.S2, CharMoveState.Stop, 0.2f, false, 0.4f, 0.3f);
                movingAction2.SetEffectTiming(EffectTiming.NONE, EffectTiming.PRE, EffectTiming.PRE);
                list.Add(movingAction2);
                opponent.infoList.Add(new RencounterManager.MovingAction(ActionDetail.Damaged, CharMoveState.Stop, 0.2f, false, 0f, 0.2f));
                opponent.infoList.Add(new RencounterManager.MovingAction(ActionDetail.Damaged, CharMoveState.Stop, 0.2f, false, 0f, 0.2f));
                opponent.infoList.Add(new RencounterManager.MovingAction(ActionDetail.Damaged, CharMoveState.Stop, 0.2f, false, 0.2f, 0.2f));
            }
            else
            {
                list = base.GetMovingAction(ref self, ref opponent);
            }
            return list;
        }
    }
    public class BehaviourAction_Apho_BoundaryOfDeath_LockAnim : BehaviourActionBase
    {
        public override List<RencounterManager.MovingAction> GetMovingAction(ref RencounterManager.ActionAfterBehaviour self, ref RencounterManager.ActionAfterBehaviour opponent)
        {
            List<RencounterManager.MovingAction> list = new List<RencounterManager.MovingAction>();
            int vanillaDiceValue = self.behaviourResultData.vanillaDiceValue;
            int resultDiceMax = self.behaviourResultData.resultDiceMax;
            bool flag = vanillaDiceValue >= 4 && vanillaDiceValue >= resultDiceMax;
            bool flag2 = false;
            if (opponent.behaviourResultData != null)
            {
                flag2 = opponent.behaviourResultData.IsFarAtk();
            }
            if (self.result == Result.Win && self.data.actionType == ActionType.Atk && flag && !flag2)
            {
                RencounterManager.MovingAction movingAction = new RencounterManager.MovingAction(ActionDetail.S1, CharMoveState.MoveForward, 30f, false, 0f, 1f);
                movingAction.SetEffectTiming(EffectTiming.PRE, EffectTiming.NONE, EffectTiming.NONE);
                movingAction.customEffectRes = "BorderOfDeath";
                list.Add(movingAction);
                //Lock Anim
                RencounterManager.MovingAction movingActionLock = new RencounterManager.MovingAction(ActionDetail.Penetrate, CharMoveState.Stop, 0f, true, 0.1f, 0.1f);
                movingActionLock.customEffectRes = "Binah_FarLock_Z";
                movingActionLock.SetEffectTiming(EffectTiming.PRE, EffectTiming.NONE, EffectTiming.NONE);
                list.Add(movingActionLock);

                RencounterManager.MovingAction item = new RencounterManager.MovingAction(ActionDetail.S1, CharMoveState.MoveForward, 0.2f, false, 1f, 1f);
                list.Add(item);
                RencounterManager.MovingAction movingAction2 = new RencounterManager.MovingAction(ActionDetail.S2, CharMoveState.Stop, 1f, false, 1.5f, 1f);
                movingAction2.SetEffectTiming(EffectTiming.NONE, EffectTiming.PRE, EffectTiming.PRE);
                list.Add(movingAction2);
                opponent.infoList.Add(new RencounterManager.MovingAction(ActionDetail.Damaged, CharMoveState.Stop, 1f, false, 0f, 1f));
                opponent.infoList.Add(new RencounterManager.MovingAction(ActionDetail.Damaged, CharMoveState.Stop, 1f, false, 0f, 1f));
                opponent.infoList.Add(new RencounterManager.MovingAction(ActionDetail.Damaged, CharMoveState.Stop, 1f, false, 1f, 1f));

            }
            else
            {
                list = base.GetMovingAction(ref self, ref opponent);
            }
            return list;
        }
    }

    public class BehaviourAction_Apho_BoundaryOfDeath_ReverseAnim : BehaviourActionBase
    {
        public override List<RencounterManager.MovingAction> GetMovingAction(ref RencounterManager.ActionAfterBehaviour self, ref RencounterManager.ActionAfterBehaviour opponent)
        {
            List<RencounterManager.MovingAction> list = new List<RencounterManager.MovingAction>();
            int vanillaDiceValue = self.behaviourResultData.vanillaDiceValue;
            int resultDiceMin = self.behaviourResultData.resultDiceMin;
            bool flag = vanillaDiceValue <= 1 && vanillaDiceValue <= resultDiceMin;
            bool flag2 = false;
            if (opponent.behaviourResultData != null)
            {
                flag2 = opponent.behaviourResultData.IsFarAtk();
            }
            if (self.result == Result.Win && self.data.actionType == ActionType.Atk && flag && !flag2)
            {
                RencounterManager.MovingAction movingAction = new RencounterManager.MovingAction(ActionDetail.S1, CharMoveState.MoveForward, 30f, false, 0f, 1f);
                movingAction.SetEffectTiming(EffectTiming.PRE, EffectTiming.NONE, EffectTiming.NONE);
                movingAction.customEffectRes = "BorderOfDeath";
                list.Add(movingAction);
                RencounterManager.MovingAction item = new RencounterManager.MovingAction(ActionDetail.S1, CharMoveState.MoveForward, 0.2f, false, 1f, 1f);
                list.Add(item);
                RencounterManager.MovingAction movingAction2 = new RencounterManager.MovingAction(ActionDetail.S2, CharMoveState.Stop, 1f, false, 1.5f, 1f);
                movingAction2.SetEffectTiming(EffectTiming.NONE, EffectTiming.PRE, EffectTiming.PRE);
                list.Add(movingAction2);
                opponent.infoList.Add(new RencounterManager.MovingAction(ActionDetail.Damaged, CharMoveState.Stop, 1f, false, 0f, 1f));
                opponent.infoList.Add(new RencounterManager.MovingAction(ActionDetail.Damaged, CharMoveState.Stop, 1f, false, 0f, 1f));
                opponent.infoList.Add(new RencounterManager.MovingAction(ActionDetail.Damaged, CharMoveState.Stop, 1f, false, 1f, 1f));
            }
            else
            {
                list = base.GetMovingAction(ref self, ref opponent);
            }
            return list;
        }
    }
}
