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

namespace Ginger.Run.RunSetActions
{
    /// <summary>
    /// Interaction logic for RunSetActionEditPage.xaml
    /// </summary>
    public partial class RunSetActionEditPage : Page
    {
        private RunSetActionBase mRunSetAction;
        public RunSetActionEditPage(RunSetActionBase RunSetAction)
        {
            InitializeComponent();

            mRunSetAction = RunSetAction;

            App.ObjFieldBinding(NameTextBox, TextBox.TextProperty, RunSetAction, RunSetActionBase.Fields.Name);
            RunAtComboBox.Init(mRunSetAction, mRunSetAction.GetRunOptions(), RunSetActionBase.Fields.RunAt);

            App.FillComboFromEnumVal(ConditionComboBox, RunSetAction.Condition);
            App.ObjFieldBinding(ConditionComboBox, ComboBox.SelectedValueProperty, RunSetAction, RunSetActionBase.Fields.Condition);

            App.ObjFieldBinding(StatusTextBox, TextBox.TextProperty, RunSetAction, RunSetActionBase.Fields.Status);
            App.ObjFieldBinding(ErrorsTextBox, TextBox.TextProperty, RunSetAction, RunSetActionBase.Fields.Errors);

            Page p = mRunSetAction.GetEditPage();
            ActionEditPageFrame.Content = p;

            if (mRunSetAction.SupportRunOnConfig)
                RunActionBtn.Visibility = Visibility.Visible;
        }

        private void RunActionBtn_Click(object sender, RoutedEventArgs e)
        {
            mRunSetAction.SolutionFolder = App.UserProfile.Solution.Folder;
            mRunSetAction.ExecuteWithRunPageBFES();
        }
    }
}