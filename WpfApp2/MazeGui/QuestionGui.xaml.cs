﻿using MazeRunnerWPF.Controller;
using System;
using System.Collections.Generic;
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

namespace MazeRunnerWPF.MazeGui
{
    /// <summary>
    /// Interaction logic for QuestionGui.xaml
    /// </summary>
    public partial class QuestionGui : Page, IGuiPage
    {
        public QuestionGui()
        {
            InitializeComponent();
        }

        public void OnDisappeared()
        {
        }

        public void OnShown()
        { }

        private void btnSubmitAnswer_Click(object sender, RoutedEventArgs e)
        {
            Console.WriteLine("Zoo wee mama!");
            GuiMediator.Instance.ShowMazeGui();
        }
    }
}
