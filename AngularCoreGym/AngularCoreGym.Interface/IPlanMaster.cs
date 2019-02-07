﻿using System.Collections.Generic;
using AngularCoreGym.Models;
using AngularCoreGym.ViewModels;

namespace AngularCoreGym.Interface
{
    public interface IPlanMaster
    {
        void InsertPlan(PlanMaster plan);
        bool CheckPlanExits(string planName);
        List<PlanMasterDisplayViewModel> GetPlanMasterList();
        PlanMasterViewModel GetPlanMasterbyId(int planId);
        bool DeletePlan(int planId);
        bool UpdatePlanMaster(PlanMaster planMaster);
        List<ActivePlanModel> GetActivePlanMasterList(int? schemeId);
        string GetAmount(int planId, int schemeId);
        int GetPlanMonthbyPlanId(int? planId);
    }
}