﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btnWord = New System.Windows.Forms.Button()
        Me.btnExcel = New System.Windows.Forms.Button()
        Me.TxtDato = New System.Windows.Forms.TextBox()
        Me.TxtDatoE = New System.Windows.Forms.TextBox()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.SuspendLayout()
        '
        'btnWord
        '
        Me.btnWord.Location = New System.Drawing.Point(476, 96)
        Me.btnWord.Name = "btnWord"
        Me.btnWord.Size = New System.Drawing.Size(99, 33)
        Me.btnWord.TabIndex = 0
        Me.btnWord.Text = "Guardar word"
        Me.btnWord.UseVisualStyleBackColor = True
        '
        'btnExcel
        '
        Me.btnExcel.Location = New System.Drawing.Point(476, 218)
        Me.btnExcel.Name = "btnExcel"
        Me.btnExcel.Size = New System.Drawing.Size(99, 40)
        Me.btnExcel.TabIndex = 1
        Me.btnExcel.Text = "Guardar Excel"
        Me.btnExcel.UseVisualStyleBackColor = True
        '
        'TxtDato
        '
        Me.TxtDato.Location = New System.Drawing.Point(180, 96)
        Me.TxtDato.Name = "TxtDato"
        Me.TxtDato.Size = New System.Drawing.Size(100, 22)
        Me.TxtDato.TabIndex = 2
        Me.TxtDato.Text = "Hola Mundo"
        '
        'TxtDatoE
        '
        Me.TxtDatoE.Location = New System.Drawing.Point(180, 218)
        Me.TxtDatoE.Name = "TxtDatoE"
        Me.TxtDatoE.Size = New System.Drawing.Size(100, 22)
        Me.TxtDatoE.TabIndex = 3
        Me.TxtDatoE.Text = "Hola Mundo"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.TxtDatoE)
        Me.Controls.Add(Me.TxtDato)
        Me.Controls.Add(Me.btnExcel)
        Me.Controls.Add(Me.btnWord)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnWord As Button
    Friend WithEvents btnExcel As Button
    Friend WithEvents TxtDato As TextBox
    Friend WithEvents TxtDatoE As TextBox
    Friend WithEvents SaveFileDialog1 As SaveFileDialog
End Class
