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
using Modelo;
using Negocio;

namespace Visao
{
    /// <summary>
    /// Lógica interna para CadastrarCompras.xaml
    /// </summary>
    public partial class CadastrarCompras : Window
    {
        public CadastrarCompras()
        {
            InitializeComponent();
        }

        NFornecedor nF;
        NProduto nP;
        Fornecedor f;
        Produto p;

        private void ListarFornecedores(object sender, RoutedEventArgs e)
        {
            nF = new NFornecedor();
            listFornecedores.ItemsSource = null;
            listFornecedores.ItemsSource = nF.Select();
        }

        private void PesquisarFornecedor(object sender, RoutedEventArgs e)
        {
            nF = new NFornecedor();
            listFornecedores.ItemsSource = null;
            listFornecedores.ItemsSource = nF.Search(pesqForn.Text);
        }

        private void ListFornecedores_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            if(listFornecedores.SelectedItem != null)
            {
                f = listFornecedores.SelectedItem as Fornecedor;
                nP = new NProduto();
                listaProdutos.ItemsSource = null;
                listaProdutos.ItemsSource = nP.Select(f.Id);
            }
        }

        private void PesquisarProduto_Click(object sender, RoutedEventArgs e)
        {
            nP = new NProduto();
            listaProdutos.ItemsSource = null;
            listaProdutos.ItemsSource = nP.Search(pesqProduto.Text, f.Id);
        }

        private void ListarProdutos(object sender, RoutedEventArgs e)
        {
            nP = new NProduto();
            listaProdutos.ItemsSource = null;
            listaProdutos.ItemsSource = nP.Select(f.Id);
        }
    }
}
