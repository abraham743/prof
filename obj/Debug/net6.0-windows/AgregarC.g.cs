﻿#pragma checksum "..\..\..\AgregarC.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "FF8ADFC8CEAA6D88F3A417F006DD4A474ED102F8"
//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

using PRecu.Tablas;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Controls.Ribbon;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Media.TextFormatting;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Shell;


namespace PRecu {
    
    
    /// <summary>
    /// AgregarC
    /// </summary>
    public partial class AgregarC : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 65 "..\..\..\AgregarC.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid datagrid_cliente;
        
        #line default
        #line hidden
        
        
        #line 79 "..\..\..\AgregarC.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtIDCliente;
        
        #line default
        #line hidden
        
        
        #line 82 "..\..\..\AgregarC.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtNombre;
        
        #line default
        #line hidden
        
        
        #line 85 "..\..\..\AgregarC.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtTelefono;
        
        #line default
        #line hidden
        
        
        #line 88 "..\..\..\AgregarC.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtCiudad;
        
        #line default
        #line hidden
        
        
        #line 91 "..\..\..\AgregarC.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtDireccion;
        
        #line default
        #line hidden
        
        
        #line 93 "..\..\..\AgregarC.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BAgregar;
        
        #line default
        #line hidden
        
        
        #line 94 "..\..\..\AgregarC.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BEditar;
        
        #line default
        #line hidden
        
        
        #line 95 "..\..\..\AgregarC.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BEliminar;
        
        #line default
        #line hidden
        
        
        #line 96 "..\..\..\AgregarC.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BRegreso;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "7.0.4.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/PRecu;component/agregarc.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\AgregarC.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "7.0.4.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.datagrid_cliente = ((System.Windows.Controls.DataGrid)(target));
            
            #line 65 "..\..\..\AgregarC.xaml"
            this.datagrid_cliente.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.datagrid_cliente_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 2:
            this.txtIDCliente = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.txtNombre = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.txtTelefono = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.txtCiudad = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.txtDireccion = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            this.BAgregar = ((System.Windows.Controls.Button)(target));
            
            #line 93 "..\..\..\AgregarC.xaml"
            this.BAgregar.Click += new System.Windows.RoutedEventHandler(this.BAgregar_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.BEditar = ((System.Windows.Controls.Button)(target));
            
            #line 94 "..\..\..\AgregarC.xaml"
            this.BEditar.Click += new System.Windows.RoutedEventHandler(this.BEditar_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            this.BEliminar = ((System.Windows.Controls.Button)(target));
            
            #line 95 "..\..\..\AgregarC.xaml"
            this.BEliminar.Click += new System.Windows.RoutedEventHandler(this.BEliminar_Click);
            
            #line default
            #line hidden
            return;
            case 10:
            this.BRegreso = ((System.Windows.Controls.Button)(target));
            
            #line 96 "..\..\..\AgregarC.xaml"
            this.BRegreso.Click += new System.Windows.RoutedEventHandler(this.BRegresar_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

