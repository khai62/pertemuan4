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
        Label1 = New Label()
        GroupBox1 = New GroupBox()
        GroupBox2 = New GroupBox()
        Button1 = New Button()
        Label2 = New Label()
        TextBox1 = New TextBox()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        RadioButton1 = New RadioButton()
        RadioButton2 = New RadioButton()
        ComboBox1 = New ComboBox()
        TextBox2 = New TextBox()
        Label6 = New Label()
        Label7 = New Label()
        Label8 = New Label()
        GroupBox1.SuspendLayout()
        GroupBox2.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(321, 35)
        Label1.Name = "Label1"
        Label1.Size = New Size(95, 15)
        Label1.TabIndex = 0
        Label1.Text = "PROGRAM SPBU"
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(TextBox1)
        GroupBox1.Controls.Add(Label2)
        GroupBox1.Location = New Point(240, 74)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(246, 76)
        GroupBox1.TabIndex = 1
        GroupBox1.TabStop = False
        GroupBox1.Text = "[ INPUT HARGA ]"
        ' 
        ' GroupBox2
        ' 
        GroupBox2.Controls.Add(TextBox2)
        GroupBox2.Controls.Add(ComboBox1)
        GroupBox2.Controls.Add(RadioButton2)
        GroupBox2.Controls.Add(RadioButton1)
        GroupBox2.Controls.Add(Label5)
        GroupBox2.Controls.Add(Label4)
        GroupBox2.Controls.Add(Label3)
        GroupBox2.Location = New Point(41, 203)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(286, 186)
        GroupBox2.TabIndex = 2
        GroupBox2.TabStop = False
        GroupBox2.Text = "BELI BERDASARKAN"
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(490, 203)
        Button1.Name = "Button1"
        Button1.Size = New Size(100, 25)
        Button1.TabIndex = 3
        Button1.Text = "Button1"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(6, 34)
        Label2.Name = "Label2"
        Label2.Size = New Size(101, 15)
        Label2.TabIndex = 0
        Label2.Text = "HARGA PER LITER"
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(122, 31)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(100, 23)
        TextBox1.TabIndex = 1
        TextBox1.Text = "10000"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(6, 29)
        Label3.Name = "Label3"
        Label3.Size = New Size(108, 15)
        Label3.TabIndex = 4
        Label3.Text = "JENIS KENDARAAN"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(6, 63)
        Label4.Name = "Label4"
        Label4.Size = New Size(113, 15)
        Label4.TabIndex = 4
        Label4.Text = "BELI BERDASARKAN"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(6, 128)
        Label5.Name = "Label5"
        Label5.Size = New Size(122, 15)
        Label5.TabIndex = 4
        Label5.Text = "JUMLAH UANG/LITER"
        ' 
        ' RadioButton1
        ' 
        RadioButton1.AutoSize = True
        RadioButton1.Location = New Point(138, 63)
        RadioButton1.Name = "RadioButton1"
        RadioButton1.Size = New Size(53, 19)
        RadioButton1.TabIndex = 4
        RadioButton1.TabStop = True
        RadioButton1.Text = "LITER"
        RadioButton1.UseVisualStyleBackColor = True
        ' 
        ' RadioButton2
        ' 
        RadioButton2.AutoSize = True
        RadioButton2.Location = New Point(138, 88)
        RadioButton2.Name = "RadioButton2"
        RadioButton2.Size = New Size(58, 19)
        RadioButton2.TabIndex = 4
        RadioButton2.TabStop = True
        RadioButton2.Text = "UANG"
        RadioButton2.UseVisualStyleBackColor = True
        ' 
        ' ComboBox1
        ' 
        ComboBox1.FormattingEnabled = True
        ComboBox1.Location = New Point(138, 26)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(121, 23)
        ComboBox1.TabIndex = 4
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(138, 125)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(100, 23)
        TextBox2.TabIndex = 4
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(388, 237)
        Label6.Name = "Label6"
        Label6.Size = New Size(124, 15)
        Label6.TabIndex = 4
        Label6.Text = "KENDARAAN RODA   :"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(388, 282)
        Label7.Name = "Label7"
        Label7.Size = New Size(125, 15)
        Label7.TabIndex = 5
        Label7.Text = "JUMLAH UANG           :"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(388, 331)
        Label8.Name = "Label8"
        Label8.Size = New Size(123, 15)
        Label8.TabIndex = 6
        Label8.Text = "JUMLAH LITER            :"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.LightSalmon
        ClientSize = New Size(757, 450)
        Controls.Add(Label8)
        Controls.Add(Label7)
        Controls.Add(Label6)
        Controls.Add(Button1)
        Controls.Add(GroupBox2)
        Controls.Add(GroupBox1)
        Controls.Add(Label1)
        Name = "Form1"
        Text = "Form1"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        GroupBox2.ResumeLayout(False)
        GroupBox2.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Button1 As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
End Class
