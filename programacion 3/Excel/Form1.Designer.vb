<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        MonthCalendar1 = New MonthCalendar()
        ListBox1 = New ListBox()
        CMes = New ComboBox()
        Cpagos = New ComboBox()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        BCancelar = New Button()
        BGuardar = New Button()
        BAgregar = New Button()
        BSalir = New Button()
        TxtNombre = New TextBox()
        TxtNumero = New TextBox()
        BExcel = New Button()
        SuspendLayout()
        ' 
        ' MonthCalendar1
        ' 
        MonthCalendar1.Location = New Point(503, 63)
        MonthCalendar1.Name = "MonthCalendar1"
        MonthCalendar1.TabIndex = 0
        ' 
        ' ListBox1
        ' 
        ListBox1.FormattingEnabled = True
        ListBox1.Location = New Point(30, 332)
        ListBox1.Name = "ListBox1"
        ListBox1.Size = New Size(364, 44)
        ListBox1.TabIndex = 1
        ' 
        ' CMes
        ' 
        CMes.FormattingEnabled = True
        CMes.Location = New Point(630, 321)
        CMes.Name = "CMes"
        CMes.Size = New Size(90, 28)
        CMes.TabIndex = 2
        ' 
        ' Cpagos
        ' 
        Cpagos.FormattingEnabled = True
        Cpagos.Location = New Point(492, 319)
        Cpagos.Name = "Cpagos"
        Cpagos.Size = New Size(107, 28)
        Cpagos.TabIndex = 3
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(501, 279)
        Label1.Name = "Label1"
        Label1.Size = New Size(54, 20)
        Label1.TabIndex = 4
        Label1.Text = "Estado"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(631, 282)
        Label2.Name = "Label2"
        Label2.Size = New Size(36, 20)
        Label2.TabIndex = 5
        Label2.Text = "Mes"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(12, 50)
        Label3.Name = "Label3"
        Label3.Size = New Size(64, 20)
        Label3.TabIndex = 8
        Label3.Text = "Nombre"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(12, 99)
        Label4.Name = "Label4"
        Label4.Size = New Size(119, 20)
        Label4.TabIndex = 9
        Label4.Text = "Numero de Casa"
        ' 
        ' BCancelar
        ' 
        BCancelar.Location = New Point(195, 177)
        BCancelar.Name = "BCancelar"
        BCancelar.Size = New Size(96, 47)
        BCancelar.TabIndex = 10
        BCancelar.Text = "Cancelar"
        BCancelar.UseVisualStyleBackColor = True
        ' 
        ' BGuardar
        ' 
        BGuardar.Location = New Point(77, 255)
        BGuardar.Name = "BGuardar"
        BGuardar.Size = New Size(96, 47)
        BGuardar.TabIndex = 11
        BGuardar.Text = "Guardar"
        BGuardar.UseVisualStyleBackColor = True
        ' 
        ' BAgregar
        ' 
        BAgregar.Location = New Point(77, 177)
        BAgregar.Name = "BAgregar"
        BAgregar.Size = New Size(96, 47)
        BAgregar.TabIndex = 12
        BAgregar.Text = "Agregar"
        BAgregar.UseVisualStyleBackColor = True
        ' 
        ' BSalir
        ' 
        BSalir.Location = New Point(195, 255)
        BSalir.Name = "BSalir"
        BSalir.RightToLeft = RightToLeft.Yes
        BSalir.Size = New Size(96, 47)
        BSalir.TabIndex = 13
        BSalir.Text = "Salir"
        BSalir.UseVisualStyleBackColor = True
        ' 
        ' TxtNombre
        ' 
        TxtNombre.Location = New Point(123, 47)
        TxtNombre.Name = "TxtNombre"
        TxtNombre.Size = New Size(97, 27)
        TxtNombre.TabIndex = 14
        ' 
        ' TxtNumero
        ' 
        TxtNumero.Location = New Point(153, 96)
        TxtNumero.Name = "TxtNumero"
        TxtNumero.Size = New Size(97, 27)
        TxtNumero.TabIndex = 15
        ' 
        ' BExcel
        ' 
        BExcel.Location = New Point(353, 174)
        BExcel.Name = "BExcel"
        BExcel.Size = New Size(93, 41)
        BExcel.TabIndex = 16
        BExcel.Text = "ir a excel"
        BExcel.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(BExcel)
        Controls.Add(TxtNumero)
        Controls.Add(TxtNombre)
        Controls.Add(BSalir)
        Controls.Add(BAgregar)
        Controls.Add(BGuardar)
        Controls.Add(BCancelar)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(Cpagos)
        Controls.Add(CMes)
        Controls.Add(ListBox1)
        Controls.Add(MonthCalendar1)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents MonthCalendar1 As MonthCalendar
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents CMes As ComboBox
    Friend WithEvents Cpagos As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents BCancelar As Button
    Friend WithEvents BGuardar As Button
    Friend WithEvents BAgregar As Button
    Friend WithEvents BSalir As Button
    Friend WithEvents TxtNombre As TextBox
    Friend WithEvents TxtNumero As TextBox
    Friend WithEvents BExcel As Button

End Class
