﻿using System;
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
using System.Windows.Shapes;

namespace Visao
{
    /// <summary>
    /// Lógica interna para TelaGerente.xaml
    /// </summary>
    public partial class TelaGerente : Window
    {
        public TelaGerente()
        {
            InitializeComponent();
        }

        private void btnCadastrarForne(object sender, RoutedEventArgs e)
        {
            CadFornecedor f = new CadFornecedor();
            f.ShowDialog();
        }

        private void btnCadComp(object sender, RoutedEventArgs e)
        {
            CadastrarCompras cc = new CadastrarCompras();
            cc.ShowDialog();
        }

        private void btnEstoque(object sender, RoutedEventArgs e)
        {
            WindowEstoque es = new WindowEstoque();
            es.ShowDialog();
        }

        private void btnAlterarDados(object sender, RoutedEventArgs e)
        {
            DadosGerente dg = new DadosGerente();
            dg.ShowDialog();
        }
    }
}
