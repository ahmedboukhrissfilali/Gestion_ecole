<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
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

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Txt_Login = New System.Windows.Forms.TextBox()
        Me.Txt_Mot_Passe = New System.Windows.Forms.TextBox()
        Me.BTN_OK = New System.Windows.Forms.Button()
        Me.BTN_Annuler = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Txt_Login
        '
        Me.Txt_Login.Location = New System.Drawing.Point(241, 12)
        Me.Txt_Login.Name = "Txt_Login"
        Me.Txt_Login.Size = New System.Drawing.Size(173, 20)
        Me.Txt_Login.TabIndex = 0
        '
        'Txt_Mot_Passe
        '
        Me.Txt_Mot_Passe.Location = New System.Drawing.Point(241, 44)
        Me.Txt_Mot_Passe.Name = "Txt_Mot_Passe"
        Me.Txt_Mot_Passe.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.Txt_Mot_Passe.Size = New System.Drawing.Size(173, 20)
        Me.Txt_Mot_Passe.TabIndex = 1
        '
        'BTN_OK
        '
        Me.BTN_OK.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BTN_OK.Location = New System.Drawing.Point(244, 111)
        Me.BTN_OK.Name = "BTN_OK"
        Me.BTN_OK.Size = New System.Drawing.Size(75, 29)
        Me.BTN_OK.TabIndex = 2
        Me.BTN_OK.Text = "OK"
        Me.BTN_OK.UseVisualStyleBackColor = True
        '
        'BTN_Annuler
        '
        Me.BTN_Annuler.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BTN_Annuler.Location = New System.Drawing.Point(325, 111)
        Me.BTN_Annuler.Name = "BTN_Annuler"
        Me.BTN_Annuler.Size = New System.Drawing.Size(89, 29)
        Me.BTN_Annuler.TabIndex = 3
        Me.BTN_Annuler.Text = "Annuler"
        Me.BTN_Annuler.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(153, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(82, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Nom utilisateur :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(157, 47)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(78, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Mot de Passe :"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Gestion_Ecole.My.Resources.Resources.cle_mot_passe_icone_3743
        Me.PictureBox1.Location = New System.Drawing.Point(12, 10)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(139, 134)
        Me.PictureBox1.TabIndex = 6
        Me.PictureBox1.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(428, 152)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BTN_Annuler)
        Me.Controls.Add(Me.BTN_OK)
        Me.Controls.Add(Me.Txt_Mot_Passe)
        Me.Controls.Add(Me.Txt_Login)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Identification"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Txt_Login As TextBox
    Friend WithEvents Txt_Mot_Passe As TextBox
    Friend WithEvents BTN_OK As Button
    Friend WithEvents BTN_Annuler As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents PictureBox1 As PictureBox
End Class
