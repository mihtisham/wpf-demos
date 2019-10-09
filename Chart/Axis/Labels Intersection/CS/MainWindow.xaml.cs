#region Copyright Syncfusion Inc. 2001-2019.
// Copyright Syncfusion Inc. 2001-2019. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using Syncfusion.UI.Xaml.Charts;
using Syncfusion.Windows.SampleLayout;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace AxisConfiguration
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : SampleLayoutWindow
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            int index = (sender as ComboBox).SelectedIndex;

            switch (index)
            {
                case 1:
                    PrimaryAxis.LabelsIntersectAction = AxisLabelsIntersectAction.MultipleRows;
                    break;

                case 2:
                    PrimaryAxis.LabelsIntersectAction = AxisLabelsIntersectAction.Hide;
                    break;

                case 3:
                    PrimaryAxis.LabelsIntersectAction = AxisLabelsIntersectAction.Auto;
                    break;

                default:
                    PrimaryAxis.LabelsIntersectAction = AxisLabelsIntersectAction.None;
                    break;
            }
        }
    }
}