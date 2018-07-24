#region License
/*
Copyright © 2014-2018 European Support Limited

Licensed under the Apache License, Version 2.0 (the "License")
you may not use this file except in compliance with the License.
You may obtain a copy of the License at 

http://www.apache.org/licenses/LICENSE-2.0 

Unless required by applicable law or agreed to in writing, software
distributed under the License is distributed on an "AS IS" BASIS, 
WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied. 
See the License for the specific language governing permissions and 
limitations under the License. 
*/
#endregion

using System.Windows;
using System.Windows.Controls;

namespace Ginger.Repository
{
    /// <summary>
    /// Interaction logic for SharedRepositoryPage.xaml
    /// </summary>
    public partial class SharedRepositorySummaryPage : Page
    {
        public SharedRepositorySummaryPage()
        {
            InitializeComponent();
            ShowData();
        }

        private void ShowData(bool fromCache=true)
        {
            ActivitiesGroupsCountLabel.Text = App.LocalRepository.GetSolutionRepoActivitiesGroups(fromCache).Count.ToString();
            ActivitiesCountLabel.Text = App.LocalRepository.GetSolutionRepoActivities(fromCache).Count.ToString();
            ActionsCountLabel.Text = App.LocalRepository.GetSolutionRepoActions(fromCache).Count.ToString();
            VariablesCountLabel.Text = App.LocalRepository.GetSolutionRepoVariables(fromCache).Count.ToString();
        }

        private void RefreshButton_Click(object sender, RoutedEventArgs e)
        {
            ShowData(false);
        }               
    }
}