﻿using System.Threading.Tasks;
using HandyControlDemo.Data;
using HandyControlDemo.Service;

namespace HandyControlDemo.ViewModel
{
    public class ContributorsViewModel : DemoViewModelBase<ContributorModel>
    {
        public ContributorsViewModel(DataService dataService)
        {
            Task.Factory.StartNew(() => DataList = dataService.GetContributorDataList());
        }
    }
}