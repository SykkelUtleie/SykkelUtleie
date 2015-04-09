<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Slett_sykkel
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.KundeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NyKundeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EnkeltKundeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GruppefamilieBedrifterOsvToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SøkIKundebaseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SlettKundeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SykkelToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RegistreringAvNySykkelToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SøkISykkelbaseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReparasjonToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SlettSykkelToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UtstyrToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RegistreringAvNyUtstyrToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SøkIUrtstyrbaseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SlettUtstyrToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BestillingToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AVSLUTTToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Button1.Location = New System.Drawing.Point(181, 317)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(193, 44)
        Me.Button1.TabIndex = 60
        Me.Button1.Text = "Slett sykkel fra databasen"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'ComboBox2
        '
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Items.AddRange(New Object() {"Barnesykkel 2 - 12 år", "Terrengsykkel", "Landeveissykkel", "Hybridsykkel", "Bysykkel", "Sparkesykkel og trehjulssykkel"})
        Me.ComboBox2.Location = New System.Drawing.Point(209, 87)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(193, 21)
        Me.ComboBox2.TabIndex = 57
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(209, 57)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(193, 21)
        Me.ComboBox1.TabIndex = 54
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(155, 90)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(37, 13)
        Me.Label2.TabIndex = 62
        Me.Label2.Text = "Merke"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(133, 60)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(59, 13)
        Me.Label1.TabIndex = 61
        Me.Label1.Text = "Sykkeltype"
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(0, 139)
        Me.DataGridView1.MultiSelect = False
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(580, 163)
        Me.DataGridView1.TabIndex = 63
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.KundeToolStripMenuItem, Me.SykkelToolStripMenuItem, Me.UtstyrToolStripMenuItem, Me.BestillingToolStripMenuItem, Me.AVSLUTTToolStripMenuItem})
        Me.MenuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(592, 24)
        Me.MenuStrip1.TabIndex = 64
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'KundeToolStripMenuItem
        '
        Me.KundeToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NyKundeToolStripMenuItem, Me.SøkIKundebaseToolStripMenuItem, Me.SlettKundeToolStripMenuItem})
        Me.KundeToolStripMenuItem.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.KundeToolStripMenuItem.Name = "KundeToolStripMenuItem"
        Me.KundeToolStripMenuItem.Size = New System.Drawing.Size(60, 20)
        Me.KundeToolStripMenuItem.Text = "Kunde"
        '
        'NyKundeToolStripMenuItem
        '
        Me.NyKundeToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EnkeltKundeToolStripMenuItem, Me.GruppefamilieBedrifterOsvToolStripMenuItem})
        Me.NyKundeToolStripMenuItem.Name = "NyKundeToolStripMenuItem"
        Me.NyKundeToolStripMenuItem.Size = New System.Drawing.Size(276, 22)
        Me.NyKundeToolStripMenuItem.Text = "Registrering/endring ny kunde"
        '
        'EnkeltKundeToolStripMenuItem
        '
        Me.EnkeltKundeToolStripMenuItem.Name = "EnkeltKundeToolStripMenuItem"
        Me.EnkeltKundeToolStripMenuItem.Size = New System.Drawing.Size(208, 22)
        Me.EnkeltKundeToolStripMenuItem.Text = "Endre kunde"
        '
        'GruppefamilieBedrifterOsvToolStripMenuItem
        '
        Me.GruppefamilieBedrifterOsvToolStripMenuItem.Name = "GruppefamilieBedrifterOsvToolStripMenuItem"
        Me.GruppefamilieBedrifterOsvToolStripMenuItem.Size = New System.Drawing.Size(208, 22)
        Me.GruppefamilieBedrifterOsvToolStripMenuItem.Text = "Registrere ny kunde"
        '
        'SøkIKundebaseToolStripMenuItem
        '
        Me.SøkIKundebaseToolStripMenuItem.Name = "SøkIKundebaseToolStripMenuItem"
        Me.SøkIKundebaseToolStripMenuItem.Size = New System.Drawing.Size(276, 22)
        Me.SøkIKundebaseToolStripMenuItem.Text = "Søk i kundebase"
        '
        'SlettKundeToolStripMenuItem
        '
        Me.SlettKundeToolStripMenuItem.Name = "SlettKundeToolStripMenuItem"
        Me.SlettKundeToolStripMenuItem.Size = New System.Drawing.Size(276, 22)
        Me.SlettKundeToolStripMenuItem.Text = "Slett kunde"
        '
        'SykkelToolStripMenuItem
        '
        Me.SykkelToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RegistreringAvNySykkelToolStripMenuItem, Me.SøkISykkelbaseToolStripMenuItem, Me.ReparasjonToolStripMenuItem, Me.SlettSykkelToolStripMenuItem})
        Me.SykkelToolStripMenuItem.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.SykkelToolStripMenuItem.Name = "SykkelToolStripMenuItem"
        Me.SykkelToolStripMenuItem.Size = New System.Drawing.Size(61, 20)
        Me.SykkelToolStripMenuItem.Text = "Sykkel"
        '
        'RegistreringAvNySykkelToolStripMenuItem
        '
        Me.RegistreringAvNySykkelToolStripMenuItem.Name = "RegistreringAvNySykkelToolStripMenuItem"
        Me.RegistreringAvNySykkelToolStripMenuItem.Size = New System.Drawing.Size(240, 22)
        Me.RegistreringAvNySykkelToolStripMenuItem.Text = "Registrering av ny sykkel"
        '
        'SøkISykkelbaseToolStripMenuItem
        '
        Me.SøkISykkelbaseToolStripMenuItem.Name = "SøkISykkelbaseToolStripMenuItem"
        Me.SøkISykkelbaseToolStripMenuItem.Size = New System.Drawing.Size(240, 22)
        Me.SøkISykkelbaseToolStripMenuItem.Text = "Søk i sykkelbase"
        '
        'ReparasjonToolStripMenuItem
        '
        Me.ReparasjonToolStripMenuItem.Name = "ReparasjonToolStripMenuItem"
        Me.ReparasjonToolStripMenuItem.Size = New System.Drawing.Size(240, 22)
        Me.ReparasjonToolStripMenuItem.Text = "Reparasjon"
        '
        'SlettSykkelToolStripMenuItem
        '
        Me.SlettSykkelToolStripMenuItem.Name = "SlettSykkelToolStripMenuItem"
        Me.SlettSykkelToolStripMenuItem.Size = New System.Drawing.Size(240, 22)
        Me.SlettSykkelToolStripMenuItem.Text = "Slett sykkel"
        '
        'UtstyrToolStripMenuItem
        '
        Me.UtstyrToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RegistreringAvNyUtstyrToolStripMenuItem, Me.SøkIUrtstyrbaseToolStripMenuItem, Me.SlettUtstyrToolStripMenuItem})
        Me.UtstyrToolStripMenuItem.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.UtstyrToolStripMenuItem.Name = "UtstyrToolStripMenuItem"
        Me.UtstyrToolStripMenuItem.Size = New System.Drawing.Size(61, 20)
        Me.UtstyrToolStripMenuItem.Text = "Utstyr"
        '
        'RegistreringAvNyUtstyrToolStripMenuItem
        '
        Me.RegistreringAvNyUtstyrToolStripMenuItem.Name = "RegistreringAvNyUtstyrToolStripMenuItem"
        Me.RegistreringAvNyUtstyrToolStripMenuItem.Size = New System.Drawing.Size(253, 22)
        Me.RegistreringAvNyUtstyrToolStripMenuItem.Text = "Registrering av nytt utstyr"
        '
        'SøkIUrtstyrbaseToolStripMenuItem
        '
        Me.SøkIUrtstyrbaseToolStripMenuItem.Name = "SøkIUrtstyrbaseToolStripMenuItem"
        Me.SøkIUrtstyrbaseToolStripMenuItem.Size = New System.Drawing.Size(253, 22)
        Me.SøkIUrtstyrbaseToolStripMenuItem.Text = "Søk i urtstyrbase"
        '
        'SlettUtstyrToolStripMenuItem
        '
        Me.SlettUtstyrToolStripMenuItem.Name = "SlettUtstyrToolStripMenuItem"
        Me.SlettUtstyrToolStripMenuItem.Size = New System.Drawing.Size(253, 22)
        Me.SlettUtstyrToolStripMenuItem.Text = "Slett utstyr"
        '
        'BestillingToolStripMenuItem
        '
        Me.BestillingToolStripMenuItem.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.BestillingToolStripMenuItem.Name = "BestillingToolStripMenuItem"
        Me.BestillingToolStripMenuItem.Size = New System.Drawing.Size(84, 20)
        Me.BestillingToolStripMenuItem.Text = "Bestilling"
        '
        'AVSLUTTToolStripMenuItem
        '
        Me.AVSLUTTToolStripMenuItem.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.AVSLUTTToolStripMenuItem.Name = "AVSLUTTToolStripMenuItem"
        Me.AVSLUTTToolStripMenuItem.Size = New System.Drawing.Size(145, 20)
        Me.AVSLUTTToolStripMenuItem.Text = "TILBAKE til oversikt"
        '
        'Slett_sykkel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(592, 373)
        Me.ControlBox = False
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.ComboBox2)
        Me.Controls.Add(Me.ComboBox1)
        Me.Name = "Slett_sykkel"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Slett sykkel"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents ComboBox2 As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents KundeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NyKundeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EnkeltKundeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GruppefamilieBedrifterOsvToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SøkIKundebaseToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SlettKundeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SykkelToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RegistreringAvNySykkelToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SøkISykkelbaseToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ReparasjonToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SlettSykkelToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UtstyrToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RegistreringAvNyUtstyrToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SøkIUrtstyrbaseToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SlettUtstyrToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BestillingToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AVSLUTTToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
