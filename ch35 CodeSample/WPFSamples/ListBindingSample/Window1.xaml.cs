﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Wrox.ProCSharp.WPF
{
   /// <summary>
   /// Interaction logic for Window1.xaml
   /// </summary>
   public partial class Window1 : Window
   {
      private BookFactory factory = new BookFactory();

      public Window1()
      {
         InitializeComponent();


         this.DataContext = factory.GetBooks();
      }

      private void addBookButton_Click(object sender, RoutedEventArgs e)
      {
         factory.AddBook(new Book(".NET 2.0 Wrox Box", "Wrox Press",
    "978-0-470-04840-5"));

      }
   }
}
