<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Endre_kunder
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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
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
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox7 = New System.Windows.Forms.TextBox()
        Me.TextBox8 = New System.Windows.Forms.TextBox()
        Me.TextBox9 = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(3, 88)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(588, 150)
        Me.DataGridView1.TabIndex = 0
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Button1.Location = New System.Drawing.Point(423, 39)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(109, 43)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Vis kunder"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.RadioButton1.Location = New System.Drawing.Point(111, 52)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(97, 17)
        Me.RadioButton1.TabIndex = 2
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "Privatkunder"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.RadioButton2.Location = New System.Drawing.Point(253, 52)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(107, 17)
        Me.RadioButton2.TabIndex = 3
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.Text = "Bedriftskunder"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.KundeToolStripMenuItem, Me.SykkelToolStripMenuItem, Me.UtstyrToolStripMenuItem, Me.BestillingToolStripMenuItem, Me.AVSLUTTToolStripMenuItem})
        Me.MenuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(600, 24)
        Me.MenuStrip1.TabIndex = 27
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
        Me.NyKundeToolStripMenuItem.Size = New System.Drawing.Size(239, 22)
        Me.NyKundeToolStripMenuItem.Text = "Registrering av ny kunde"
        '
        'EnkeltKundeToolStripMenuItem
        '
        Me.EnkeltKundeToolStripMenuItem.Name = "EnkeltKundeToolStripMenuItem"
        Me.EnkeltKundeToolStripMenuItem.Size = New System.Drawing.Size(276, 22)
        Me.EnkeltKundeToolStripMenuItem.Text = "Enkelt kunde"
        '
        'GruppefamilieBedrifterOsvToolStripMenuItem
        '
        Me.GruppefamilieBedrifterOsvToolStripMenuItem.Name = "GruppefamilieBedrifterOsvToolStripMenuItem"
        Me.GruppefamilieBedrifterOsvToolStripMenuItem.Size = New System.Drawing.Size(276, 22)
        Me.GruppefamilieBedrifterOsvToolStripMenuItem.Text = "Gruppe (familie, bedrifter osv.)"
        '
        'SøkIKundebaseToolStripMenuItem
        '
        Me.SøkIKundebaseToolStripMenuItem.Name = "SøkIKundebaseToolStripMenuItem"
        Me.SøkIKundebaseToolStripMenuItem.Size = New System.Drawing.Size(239, 22)
        Me.SøkIKundebaseToolStripMenuItem.Text = "Søk i kundebase"
        '
        'SlettKundeToolStripMenuItem
        '
        Me.SlettKundeToolStripMenuItem.Name = "SlettKundeToolStripMenuItem"
        Me.SlettKundeToolStripMenuItem.Size = New System.Drawing.Size(239, 22)
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
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 366)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(80, 13)
        Me.Label5.TabIndex = 38
        Me.Label5.Text = "Telefonnummer"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(48, 334)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(37, 13)
        Me.Label3.TabIndex = 36
        Me.Label3.Text = "E-post"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(21, 304)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(65, 13)
        Me.Label4.TabIndex = 37
        Me.Label4.Text = "Postadresse"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(33, 274)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 13)
        Me.Label2.TabIndex = 35
        Me.Label2.Text = "Etternavn"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(39, 247)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(46, 13)
        Me.Label1.TabIndex = 34
        Me.Label1.Text = "Fornavn"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TextBox6
        '
        Me.TextBox6.Location = New System.Drawing.Point(101, 363)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.ReadOnly = True
        Me.TextBox6.Size = New System.Drawing.Size(144, 20)
        Me.TextBox6.TabIndex = 32
        '
        'TextBox5
        '
        Me.TextBox5.Location = New System.Drawing.Point(101, 331)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.ReadOnly = True
        Me.TextBox5.Size = New System.Drawing.Size(144, 20)
        Me.TextBox5.TabIndex = 31
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(101, 301)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.ReadOnly = True
        Me.TextBox4.Size = New System.Drawing.Size(144, 20)
        Me.TextBox4.TabIndex = 30
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(101, 271)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.ReadOnly = True
        Me.TextBox2.Size = New System.Drawing.Size(144, 20)
        Me.TextBox2.TabIndex = 29
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(101, 244)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(144, 20)
        Me.TextBox1.TabIndex = 28
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(184, 398)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(227, 37)
        Me.Button2.TabIndex = 40
        Me.Button2.Text = "Lagre endringene"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(408, 244)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.ReadOnly = True
        Me.TextBox3.Size = New System.Drawing.Size(144, 20)
        Me.TextBox3.TabIndex = 41
        '
        'TextBox7
        '
        Me.TextBox7.Location = New System.Drawing.Point(408, 271)
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.ReadOnly = True
        Me.TextBox7.Size = New System.Drawing.Size(144, 20)
        Me.TextBox7.TabIndex = 42
        '
        'TextBox8
        '
        Me.TextBox8.Location = New System.Drawing.Point(408, 301)
        Me.TextBox8.Name = "TextBox8"
        Me.TextBox8.ReadOnly = True
        Me.TextBox8.Size = New System.Drawing.Size(144, 20)
        Me.TextBox8.TabIndex = 43
        '
        'TextBox9
        '
        Me.TextBox9.Location = New System.Drawing.Point(408, 331)
        Me.TextBox9.Name = "TextBox9"
        Me.TextBox9.ReadOnly = True
        Me.TextBox9.Size = New System.Drawing.Size(144, 20)
        Me.TextBox9.TabIndex = 44
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(349, 247)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(51, 13)
        Me.Label7.TabIndex = 45
        Me.Label7.Text = "Org.navn"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(335, 274)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(65, 13)
        Me.Label8.TabIndex = 46
        Me.Label8.Text = "Postadresse"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(320, 304)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(80, 13)
        Me.Label9.TabIndex = 47
        Me.Label9.Text = "Telefonnummer"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(363, 334)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(37, 13)
        Me.Label10.TabIndex = 48
        Me.Label10.Text = "E-post"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Endre_kunder
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(600, 450)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.TextBox9)
        Me.Controls.Add(Me.TextBox8)
        Me.Controls.Add(Me.TextBox7)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBox6)
        Me.Controls.Add(Me.TextBox5)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.RadioButton2)
        Me.Controls.Add(Me.RadioButton1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "Endre_kunder"
        Me.Text = "Endre_kunder"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents RadioButton1 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton2 As System.Windows.Forms.RadioButton
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
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TextBox6 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox5 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox4 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox7 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox8 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox9 As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
End Class
