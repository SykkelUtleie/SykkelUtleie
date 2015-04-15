<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Registrering_av_gruppe
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.DateTimePicker3 = New System.Windows.Forms.DateTimePicker()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
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
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.GroupBox5)
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 28)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(568, 334)
        Me.GroupBox1.TabIndex = 14
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Registrering"
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.RadioButton2)
        Me.GroupBox5.Controls.Add(Me.RadioButton1)
        Me.GroupBox5.Location = New System.Drawing.Point(194, 19)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(174, 59)
        Me.GroupBox5.TabIndex = 33
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Velg kunde:"
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Location = New System.Drawing.Point(77, 21)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(86, 17)
        Me.RadioButton2.TabIndex = 32
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.Text = "Organisasjon"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Location = New System.Drawing.Point(14, 21)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(52, 17)
        Me.RadioButton1.TabIndex = 31
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "Privat"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.DateTimePicker3)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.TextBox6)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.TextBox5)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.TextBox4)
        Me.GroupBox2.Controls.Add(Me.TextBox2)
        Me.GroupBox2.Controls.Add(Me.TextBox1)
        Me.GroupBox2.Location = New System.Drawing.Point(144, 84)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(262, 210)
        Me.GroupBox2.TabIndex = 17
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Opplysninger:"
        '
        'DateTimePicker3
        '
        Me.DateTimePicker3.Location = New System.Drawing.Point(102, 178)
        Me.DateTimePicker3.Name = "DateTimePicker3"
        Me.DateTimePicker3.Size = New System.Drawing.Size(144, 20)
        Me.DateTimePicker3.TabIndex = 15
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(52, 149)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(37, 13)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "E-post"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TextBox6
        '
        Me.TextBox6.Location = New System.Drawing.Point(102, 146)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(144, 20)
        Me.TextBox6.TabIndex = 13
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(9, 117)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(80, 13)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Telefonnummer"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TextBox5
        '
        Me.TextBox5.Location = New System.Drawing.Point(102, 114)
        Me.TextBox5.MaxLength = 8
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(144, 20)
        Me.TextBox5.TabIndex = 11
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(25, 181)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(64, 13)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Fødselsdato"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(24, 87)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(65, 13)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Postadresse"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(36, 57)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 13)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Etternavn"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(42, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(46, 13)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Fornavn"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(102, 84)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(144, 20)
        Me.TextBox4.TabIndex = 6
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(102, 54)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(144, 20)
        Me.TextBox2.TabIndex = 4
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(102, 27)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(144, 20)
        Me.TextBox1.TabIndex = 3
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Button1.Location = New System.Drawing.Point(163, 301)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(214, 27)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Register kunde i databasen"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.KundeToolStripMenuItem, Me.SykkelToolStripMenuItem, Me.UtstyrToolStripMenuItem, Me.BestillingToolStripMenuItem, Me.AVSLUTTToolStripMenuItem})
        Me.MenuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(592, 24)
        Me.MenuStrip1.TabIndex = 15
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
        Me.NyKundeToolStripMenuItem.Text = "Registrering/endring av kunde"
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
        Me.BestillingToolStripMenuItem.Size = New System.Drawing.Size(213, 20)
        Me.BestillingToolStripMenuItem.Text = "Bestilling og tilbakelevering"
        '
        'AVSLUTTToolStripMenuItem
        '
        Me.AVSLUTTToolStripMenuItem.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.AVSLUTTToolStripMenuItem.Name = "AVSLUTTToolStripMenuItem"
        Me.AVSLUTTToolStripMenuItem.Size = New System.Drawing.Size(145, 20)
        Me.AVSLUTTToolStripMenuItem.Text = "TILBAKE til oversikt"
        '
        'Registrering_av_gruppe
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(592, 373)
        Me.ControlBox = False
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Registrering_av_gruppe"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Registrering av gruppe"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents RadioButton2 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton1 As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents DateTimePicker3 As System.Windows.Forms.DateTimePicker
    Friend WithEvents TextBox6 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox5 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox4 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
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
