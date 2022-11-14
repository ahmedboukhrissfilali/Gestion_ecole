<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Principale
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FichierToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EtudiantToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProfesseurToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FonctionnaireToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.QuitterToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.InscriptionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NouvelleToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListeDesInscritsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EvaluationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NouvelleToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConsultationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GilleDévaluationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DocumentToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AttestionScolaritéToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FicheDeRéinscriptionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AideToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AideToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.AProposToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FichierToolStripMenuItem, Me.InscriptionToolStripMenuItem, Me.EvaluationToolStripMenuItem, Me.DocumentToolStripMenuItem, Me.AideToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(800, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FichierToolStripMenuItem
        '
        Me.FichierToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EtudiantToolStripMenuItem, Me.ToolStripSeparator1, Me.ProfesseurToolStripMenuItem, Me.FonctionnaireToolStripMenuItem, Me.ToolStripSeparator2, Me.QuitterToolStripMenuItem})
        Me.FichierToolStripMenuItem.Name = "FichierToolStripMenuItem"
        Me.FichierToolStripMenuItem.Size = New System.Drawing.Size(54, 20)
        Me.FichierToolStripMenuItem.Text = "Fichier"
        '
        'EtudiantToolStripMenuItem
        '
        Me.EtudiantToolStripMenuItem.Name = "EtudiantToolStripMenuItem"
        Me.EtudiantToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.EtudiantToolStripMenuItem.Text = "Etudiant ..."
        '
        'ProfesseurToolStripMenuItem
        '
        Me.ProfesseurToolStripMenuItem.Name = "ProfesseurToolStripMenuItem"
        Me.ProfesseurToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.ProfesseurToolStripMenuItem.Text = "Professeur ..."
        '
        'FonctionnaireToolStripMenuItem
        '
        Me.FonctionnaireToolStripMenuItem.Name = "FonctionnaireToolStripMenuItem"
        Me.FonctionnaireToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.FonctionnaireToolStripMenuItem.Text = "Fonctionnaire ..."
        '
        'QuitterToolStripMenuItem
        '
        Me.QuitterToolStripMenuItem.Name = "QuitterToolStripMenuItem"
        Me.QuitterToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.F4), System.Windows.Forms.Keys)
        Me.QuitterToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.QuitterToolStripMenuItem.Text = "Quitter"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(177, 6)
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(177, 6)
        '
        'InscriptionToolStripMenuItem
        '
        Me.InscriptionToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NouvelleToolStripMenuItem, Me.ListeDesInscritsToolStripMenuItem})
        Me.InscriptionToolStripMenuItem.Name = "InscriptionToolStripMenuItem"
        Me.InscriptionToolStripMenuItem.Size = New System.Drawing.Size(75, 20)
        Me.InscriptionToolStripMenuItem.Text = "Inscription"
        '
        'NouvelleToolStripMenuItem
        '
        Me.NouvelleToolStripMenuItem.Name = "NouvelleToolStripMenuItem"
        Me.NouvelleToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.NouvelleToolStripMenuItem.Text = "Nouvelle ..."
        '
        'ListeDesInscritsToolStripMenuItem
        '
        Me.ListeDesInscritsToolStripMenuItem.Name = "ListeDesInscritsToolStripMenuItem"
        Me.ListeDesInscritsToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.ListeDesInscritsToolStripMenuItem.Text = "Liste des inscrits ..."
        '
        'EvaluationToolStripMenuItem
        '
        Me.EvaluationToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NouvelleToolStripMenuItem1, Me.ConsultationToolStripMenuItem, Me.GilleDévaluationToolStripMenuItem})
        Me.EvaluationToolStripMenuItem.Name = "EvaluationToolStripMenuItem"
        Me.EvaluationToolStripMenuItem.Size = New System.Drawing.Size(74, 20)
        Me.EvaluationToolStripMenuItem.Text = "Evaluation"
        '
        'NouvelleToolStripMenuItem1
        '
        Me.NouvelleToolStripMenuItem1.Name = "NouvelleToolStripMenuItem1"
        Me.NouvelleToolStripMenuItem1.Size = New System.Drawing.Size(180, 22)
        Me.NouvelleToolStripMenuItem1.Text = "Nouvelle ..."
        '
        'ConsultationToolStripMenuItem
        '
        Me.ConsultationToolStripMenuItem.Name = "ConsultationToolStripMenuItem"
        Me.ConsultationToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.ConsultationToolStripMenuItem.Text = "Consultation ..."
        '
        'GilleDévaluationToolStripMenuItem
        '
        Me.GilleDévaluationToolStripMenuItem.Name = "GilleDévaluationToolStripMenuItem"
        Me.GilleDévaluationToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.GilleDévaluationToolStripMenuItem.Text = "Gille d'évaluation ..."
        '
        'DocumentToolStripMenuItem
        '
        Me.DocumentToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AttestionScolaritéToolStripMenuItem, Me.FicheDeRéinscriptionToolStripMenuItem})
        Me.DocumentToolStripMenuItem.Name = "DocumentToolStripMenuItem"
        Me.DocumentToolStripMenuItem.Size = New System.Drawing.Size(75, 20)
        Me.DocumentToolStripMenuItem.Text = "Document"
        '
        'AttestionScolaritéToolStripMenuItem
        '
        Me.AttestionScolaritéToolStripMenuItem.Name = "AttestionScolaritéToolStripMenuItem"
        Me.AttestionScolaritéToolStripMenuItem.Size = New System.Drawing.Size(199, 22)
        Me.AttestionScolaritéToolStripMenuItem.Text = "Attestion scolarité ..."
        '
        'FicheDeRéinscriptionToolStripMenuItem
        '
        Me.FicheDeRéinscriptionToolStripMenuItem.Name = "FicheDeRéinscriptionToolStripMenuItem"
        Me.FicheDeRéinscriptionToolStripMenuItem.Size = New System.Drawing.Size(199, 22)
        Me.FicheDeRéinscriptionToolStripMenuItem.Text = "Fiche de réinscription ..."
        '
        'AideToolStripMenuItem
        '
        Me.AideToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AideToolStripMenuItem1, Me.ToolStripSeparator3, Me.AProposToolStripMenuItem})
        Me.AideToolStripMenuItem.Name = "AideToolStripMenuItem"
        Me.AideToolStripMenuItem.Size = New System.Drawing.Size(43, 20)
        Me.AideToolStripMenuItem.Text = "Aide"
        '
        'AideToolStripMenuItem1
        '
        Me.AideToolStripMenuItem1.Name = "AideToolStripMenuItem1"
        Me.AideToolStripMenuItem1.Size = New System.Drawing.Size(180, 22)
        Me.AideToolStripMenuItem1.Text = "Aide"
        '
        'AProposToolStripMenuItem
        '
        Me.AProposToolStripMenuItem.Name = "AProposToolStripMenuItem"
        Me.AProposToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.AProposToolStripMenuItem.Text = "A propos ..."
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(177, 6)
        '
        'Frm_Principale
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.MenuStrip1)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Frm_Principale"
        Me.Text = "Gestion des étudiants de l'école ETEC"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FichierToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EtudiantToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents ProfesseurToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FonctionnaireToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents QuitterToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents InscriptionToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NouvelleToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ListeDesInscritsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EvaluationToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NouvelleToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ConsultationToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GilleDévaluationToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DocumentToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AttestionScolaritéToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FicheDeRéinscriptionToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AideToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AideToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator3 As ToolStripSeparator
    Friend WithEvents AProposToolStripMenuItem As ToolStripMenuItem
End Class
