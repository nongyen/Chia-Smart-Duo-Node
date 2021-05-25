Imports Newtonsoft.Json.Linq
Imports System.Text
Imports System
Imports System.Net
Imports System.IO
Imports System.Net.Sockets
Imports Newtonsoft.Json

Public Class main

    Dim status_run = "No"
    Dim connect_success = 0
    Dim connect_error = 0
    Dim datajson As String = ""

    Private Sub get_node()
        Try
            Dim request As HttpWebRequest
            Dim response As HttpWebResponse = Nothing
            Dim reader As StreamReader
            request = DirectCast(WebRequest.Create("https://www.lazstatement.com/auto-node-chia"), HttpWebRequest)

            response = DirectCast(request.GetResponse(), HttpWebResponse)
            reader = New StreamReader(response.GetResponseStream())

            Dim rawresp As String
            rawresp = reader.ReadToEnd()
            datajson = rawresp

            Dim json As JObject = JObject.Parse(datajson)
            Dim o As JObject = JObject.Parse(json.ToString)
            Dim results As List(Of JToken) = o.Children().ToList
            ListView1.Items.Clear()
            Dim count As String = ""
            connect_success = 0
            connect_error = 0
            ListView1.Items.Clear()
            Dim chia_exe = chia_dir & "\resources\app.asar.unpacked\daemon\"
            For Each item As JProperty In results
                item.CreateReader()
                Select Case item.Name
                    Case "data"

                        For Each subitem In item.Value
                            If status_run = "Stop" Then
                                Dim ip As String = subitem("ip").ToString
                                Dim ip_Split = ip.Split(":")
                                count = ListView1.Items.Count + 1
                                Dim lvi As New ListViewItem(count)
                                lvi.UseItemStyleForSubItems = False
                                lvi.SubItems.Add(ip)
                                lvi.SubItems.Add("Stopped")
                                lvi.SubItems(2).BackColor = Color.DarkRed
                                lvi.SubItems(2).ForeColor = Color.White
                                ListView1.Items.Add(lvi)
                                run_node.Stop()
                                Exit For

                            Else


                                Dim ip As String = subitem("ip").ToString
                                Dim ip_Split = ip.Split(":")
                                count = ListView1.Items.Count + 1
                                Dim lvi As New ListViewItem(count)
                                lvi.UseItemStyleForSubItems = False
                                lvi.SubItems.Add(ip)
                                Dim PortOpen = IsPortOpen(ip_Split(0), ip_Split(1))
                                If (PortOpen(0) Is "True" AndAlso Int(PortOpen(1)) < 500) Then
                                    lvi.SubItems.Add("Success")
                                    connect_success = connect_success + 1
                                    lvi.SubItems(2).BackColor = Color.Green
                                    lvi.SubItems(2).ForeColor = Color.White
                                    FlatLabel4.Text = "Connected " & connect_success

                                    Dim p As Process = New Process()
                                    p.StartInfo = New ProcessStartInfo("chia.exe")
                                    p.StartInfo.WorkingDirectory = chia_exe
                                    p.StartInfo.Arguments = "show -a " & ip
                                    p.StartInfo.WindowStyle = ProcessWindowStyle.Hidden
                                    p.Start()
                                Else
                                    lvi.SubItems.Add("Connect Error")
                                    connect_error = connect_error + 1
                                    lvi.SubItems(2).BackColor = Color.DarkRed
                                    lvi.SubItems(2).ForeColor = Color.White
                                    FlatLabel5.Text = "Connect failed " & connect_error

                                End If 
                                ListView1.Items.Add(lvi)

                                ListView1.Items(ListView1.Items.Count - 1).EnsureVisible()
                                Threading.Thread.Sleep(800)
                            End If
                        Next
                End Select

            Next
            ListView1.Items(ListView1.Items.Count - 1).Selected = True
            ListView1.Items(ListView1.Items.Count - 1).EnsureVisible()
            If status_run = "Stop" Then
                FlatLabel3.Text = "Stopped!"
                FlatLabel3.ForeColor = Color.DarkOrange
            Else
                FlatLabel3.Text = "Finish [Auto Run in 10 minutes]"
            End If
            status_run = "No"
            FlatButton1.Enabled = True
            FlatButton2.Enabled = False
            FlatTextBox1.Enabled = False
            'FlatButton3.Enabled = True
            RadioButton1.Enabled = True
            RadioButton2.Enabled = True
            FlatButton4.Enabled = True
        Catch ex As Exception
            status_run = "No"
            FlatLabel3.Text = "Error " & ex.Message
            FlatButton1.Enabled = True
            FlatButton2.Enabled = False
            FlatTextBox1.Enabled = False
            'FlatButton3.Enabled = True
            RadioButton1.Enabled = True
            RadioButton2.Enabled = True
            FlatButton4.Enabled = True
        End Try
    End Sub
    Private Sub get_node_fromlfile()
        Try

            ListView1.Items.Clear()
            Dim count As String = ""
            connect_success = 0
            connect_error = 0
            ListView1.Items.Clear()
            Dim chia_exe = chia_dir & "\resources\app.asar.unpacked\daemon\"
            Dim lines() As String = IO.File.ReadAllLines(data_fromfile_local)
            For Each i As String In lines
                Dim words = i.Split(":")
                Dim ip = words(0)
                Dim Port = words(1)
                If status_run = "Stop" Then
                    count = ListView1.Items.Count + 1
                    Dim lvi As New ListViewItem(count)
                    lvi.UseItemStyleForSubItems = False
                    lvi.SubItems.Add(i)
                    lvi.SubItems.Add("Stopped")
                    lvi.SubItems(2).BackColor = Color.DarkRed
                    lvi.SubItems(2).ForeColor = Color.White
                    ListView1.Items.Add(lvi)
                    run_node_fromfile.Stop()
                    Exit For

                Else
                    count = ListView1.Items.Count + 1
                    Dim lvi As New ListViewItem(count)
                    lvi.UseItemStyleForSubItems = False
                    lvi.SubItems.Add(i)
                    Dim PortOpen = IsPortOpen(ip, Port)
                    If (PortOpen(0) Is "True" AndAlso Int(PortOpen(1)) < 500) Then
                        lvi.SubItems.Add("Success")
                        connect_success = connect_success + 1
                        lvi.SubItems(2).BackColor = Color.Green
                        lvi.SubItems(2).ForeColor = Color.White
                        FlatLabel4.Text = "Connected " & connect_success

                        'Dim p As Process = New Process()
                        'p.StartInfo = New ProcessStartInfo("chia.exe")
                        'p.StartInfo.WorkingDirectory = chia_exe
                        'p.StartInfo.Arguments = "show -a " & i
                        'p.StartInfo.WindowStyle = ProcessWindowStyle.Hidden
                        'p.Start()
                    Else
                        lvi.SubItems.Add("Connect Error")
                        connect_error = connect_error + 1
                        lvi.SubItems(2).BackColor = Color.DarkRed
                        lvi.SubItems(2).ForeColor = Color.White
                        FlatLabel5.Text = "Connect failed " & connect_error

                    End If
                    ListView1.Items.Add(lvi)

                    ListView1.Items(ListView1.Items.Count - 1).EnsureVisible()
                    Threading.Thread.Sleep(800)
                End If
            Next

            ListView1.Items(ListView1.Items.Count - 1).Selected = True
            ListView1.Items(ListView1.Items.Count - 1).EnsureVisible()
            If status_run = "Stop" Then
                FlatLabel3.Text = "Stopped!"
                FlatLabel3.ForeColor = Color.DarkOrange
                run_node_fromfile.Stop()
            Else
                FlatLabel3.Text = "Finish [Auto Run in 10 minutes]"
            End If
            status_run = "No"
            FlatButton1.Enabled = True
            FlatButton2.Enabled = False
            FlatTextBox1.Enabled = False
            'FlatButton3.Enabled = True
            RadioButton1.Enabled = True
            RadioButton2.Enabled = True
            FlatButton4.Enabled = True
        Catch ex As Exception
            run_node_fromfile.Stop()
            status_run = "No"
            FlatLabel3.Text = "Error: " & ex.Message
            FlatButton1.Enabled = True
            FlatButton2.Enabled = False
            FlatTextBox1.Enabled = False
            'FlatButton3.Enabled = True
            RadioButton1.Enabled = True
            RadioButton2.Enabled = True
            FlatButton4.Enabled = True
        End Try
    End Sub
    Dim chia_dir
    Dim chia_ver

    Private Sub FlatButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FlatButton1.Click
        chia_ver = FlatTextBox1.Text
        chia_dir = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) & "\chia-blockchain\app-" & chia_ver

        If (Not System.IO.Directory.Exists(chia_dir)) Then
            MessageBox.Show("Sorry, but the version you entered cannot be found. " & chia_ver & " Please try again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            If RadioButton1.Checked = True Then
                If datajson <> Nothing Then
                    status_run = "Yes"
                    FlatLabel3.Text = "Working.."
                    FlatLabel3.ForeColor = Color.Cyan
                    Dim run_nodes As New Threading.Thread(AddressOf get_node)
                    CheckForIllegalCrossThreadCalls = False
                    run_nodes.Start()
                    FlatButton1.Enabled = False
                    FlatButton2.Enabled = True
                    FlatTextBox1.Enabled = False
                    FlatButton3.Enabled = False
                    RadioButton1.Enabled = False
                    RadioButton2.Enabled = False
                    FlatButton4.Enabled = False
                    FlatLabel4.Text = "Connected 0"
                    FlatLabel5.Text = "Connect failed 0"
                    My.Settings.chia_ver = FlatTextBox1.Text
                    My.Settings.Save()
                    My.Settings.Reload()
                    run_node.Start()
                Else
                    MessageBox.Show("No data node found, please try again. ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If

            ElseIf RadioButton2.Checked = True Then
                'check my data
                If data_fromfile = Nothing Then
                    MessageBox.Show("Please Select Node File", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Else
                    If select_file = "Yes" Then
                        status_run = "Yes"
                        FlatLabel3.Text = "Working.."
                        FlatLabel3.ForeColor = Color.Cyan
                        Dim run_nodes As New Threading.Thread(AddressOf get_node_fromlfile)
                        CheckForIllegalCrossThreadCalls = False
                        run_nodes.Start()
                        FlatButton1.Enabled = False
                        FlatButton2.Enabled = True
                        FlatTextBox1.Enabled = False
                        FlatButton3.Enabled = False
                        RadioButton1.Enabled = False
                        RadioButton2.Enabled = False
                        FlatButton4.Enabled = False
                        FlatLabel4.Text = "Connected 0"
                        FlatLabel5.Text = "Connect failed 0"
                        My.Settings.chia_ver = FlatTextBox1.Text
                        My.Settings.Save()
                        My.Settings.Reload()
                        run_node_fromfile.Start()
                    ElseIf select_file = "No" Then
                        MessageBox.Show("Please Select Node File", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If

                End If
            End If


        End If
    End Sub

    Private Sub FlatClose1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FlatClose1.Click
        Application.Exit()
    End Sub

    Private Sub FlatButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FlatButton2.Click
        status_run = "Stop"
        FlatButton1.Enabled = True
        FlatButton2.Enabled = False
        FlatTextBox1.Enabled = False
        'FlatButton3.Enabled = True
        RadioButton1.Enabled = True
        RadioButton2.Enabled = True
        FlatButton4.Enabled = True
    End Sub
    Public Shared Function PingHost(ByVal hostUri As String, ByVal portNumber As Integer) As Boolean
        Try

            Using client = New TcpClient(hostUri, portNumber)
                Return True
            End Using

        Catch ex As SocketException

            Return False
        End Try
    End Function

    Private Sub main_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Try
 
            Dim chia_dir_1 = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) & "\chia-blockchain\app-1.1.1" & chia_ver
            Dim chia_dir_2 = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) & "\chia-blockchain\app-1.1.2" & chia_ver
            Dim chia_dir_3 = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) & "\chia-blockchain\app-1.1.3" & chia_ver
            Dim chia_dir_4 = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) & "\chia-blockchain\app-1.1.4" & chia_ver
            Dim chia_dir_5 = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) & "\chia-blockchain\app-1.1.5" & chia_ver
            Dim chia_dir_6 = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) & "\chia-blockchain\app-1.1.6" & chia_ver
            Dim chia_dir_7 = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) & "\chia-blockchain\app-1.1.7" & chia_ver
            Dim chia_dir_8 = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) & "\chia-blockchain\app-1.1.8" & chia_ver
            Dim chia_dir_9 = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) & "\chia-blockchain\app-1.1.9" & chia_ver
            Dim chia_dir_10 = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) & "\chia-blockchain\app-1.2.0" & chia_ver
            Dim chia_dir_11 = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) & "\chia-blockchain\app-1.2.1" & chia_ver

            Try
                If (System.IO.Directory.Exists(chia_dir_1)) Then
                    chia_ver = "1.1.1"
                    FlatTextBox1.Text = "1.1.1"
                    My.Settings.chia_ver = chia_ver
                ElseIf (System.IO.Directory.Exists(chia_dir_2)) Then
                    chia_ver = "1.1.2"
                    FlatTextBox1.Text = "1.1.2"
                    My.Settings.chia_ver = chia_ver
                ElseIf (System.IO.Directory.Exists(chia_dir_3)) Then
                    chia_ver = "1.1.3"
                    FlatTextBox1.Text = "1.1.3"
                    My.Settings.chia_ver = chia_ver
                ElseIf (System.IO.Directory.Exists(chia_dir_4)) Then
                    chia_ver = "1.1.4"
                    FlatTextBox1.Text = "1.1.4"
                    My.Settings.chia_ver = chia_ver
                ElseIf (System.IO.Directory.Exists(chia_dir_5)) Then
                    chia_ver = "1.1.5"
                    FlatTextBox1.Text = "1.1.5"
                    My.Settings.chia_ver = chia_ver
                ElseIf (System.IO.Directory.Exists(chia_dir_6)) Then
                    chia_ver = "1.1.6"
                    FlatTextBox1.Text = "1.1.6"
                    My.Settings.chia_ver = chia_ver
                ElseIf (System.IO.Directory.Exists(chia_dir_7)) Then
                    chia_ver = "1.1.7"
                    FlatTextBox1.Text = "1.1.7"
                    My.Settings.chia_ver = chia_ver
                ElseIf (System.IO.Directory.Exists(chia_dir_8)) Then
                    chia_ver = "1.1.8"
                    FlatTextBox1.Text = "1.1.8"
                    My.Settings.chia_ver = chia_ver
                ElseIf (System.IO.Directory.Exists(chia_dir_9)) Then
                    chia_ver = "1.1.9"
                    FlatTextBox1.Text = "1.1.9"
                    My.Settings.chia_ver = chia_ver
                ElseIf (System.IO.Directory.Exists(chia_dir_10)) Then
                    chia_ver = "1.2.0"
                    FlatTextBox1.Text = "1.2.0"
                    My.Settings.chia_ver = chia_ver
                ElseIf (System.IO.Directory.Exists(chia_dir_11)) Then
                    chia_ver = "1.2.1"
                    FlatTextBox1.Text = "1.2.1"
                    My.Settings.chia_ver = chia_ver
                Else
                    chia_ver = ""
                    FlatTextBox1.Text = ""
                    My.Settings.chia_ver = chia_ver
                End If
            Catch ex As Exception

            End Try



            FlatTextBox1.Text = My.Settings.chia_ver
            Dim autocheck_nodeonline As New Threading.Thread(AddressOf get_count_node)
            CheckForIllegalCrossThreadCalls = False
            autocheck_nodeonline.Start()

            Dim request As HttpWebRequest
            Dim response As HttpWebResponse = Nothing
            Dim reader As StreamReader
            request = DirectCast(WebRequest.Create("https://www.lazstatement.com/auto-node-chia"), HttpWebRequest)

            response = DirectCast(request.GetResponse(), HttpWebResponse)
            reader = New StreamReader(response.GetResponseStream())

            Dim rawresp As String
            rawresp = reader.ReadToEnd()
            datajson = rawresp
            If datajson <> Nothing Then
                Dim jResults As Object = JObject.Parse(rawresp)
                Dim total_ip = jResults("count").ToString
                FlatLabel3.Text = "Ready (" & total_ip & " Node)"
                FlatLabel3.ForeColor = Color.Lime
            Else
                FlatLabel3.Text = "Not Ready (Please Re-Load Node)"
                FlatLabel3.ForeColor = Color.DarkOrange
            End If

        Catch ex As Exception

        End Try
    End Sub

    Private Sub FlatButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FlatButton3.Click
        Try

            Dim request As HttpWebRequest
            Dim response As HttpWebResponse = Nothing
            Dim reader As StreamReader
            request = DirectCast(WebRequest.Create("https://www.lazstatement.com/auto-node-chia"), HttpWebRequest)

            response = DirectCast(request.GetResponse(), HttpWebResponse)
            reader = New StreamReader(response.GetResponseStream())

            Dim rawresp As String
            rawresp = reader.ReadToEnd()
            datajson = rawresp
            If datajson <> Nothing Then
                Dim jResults As Object = JObject.Parse(rawresp)
                Dim total_ip = jResults("count").ToString
                FlatLabel3.Text = "Ready (" & total_ip & " Node)"
                FlatLabel3.ForeColor = Color.Lime
            Else
                FlatLabel3.Text = "Not Ready (Please Re-Load Node)"
                FlatLabel3.ForeColor = Color.DarkOrange
            End If
        Catch ex As Exception
            '  MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub run_node_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles run_node.Tick
        status_run = "Yes"
        FlatLabel3.Text = "Working.."
        FlatLabel3.ForeColor = Color.Cyan
        Dim run_nodes As New Threading.Thread(AddressOf get_node)
        CheckForIllegalCrossThreadCalls = False
        run_nodes.Start()
        FlatButton1.Enabled = False
        FlatButton2.Enabled = True
        FlatTextBox1.Enabled = False
        FlatLabel4.Text = "Connected 0"
        FlatLabel5.Text = "Connect failed 0"
        My.Settings.chia_ver = FlatTextBox1.Text
        My.Settings.Save()
        My.Settings.Reload()
        run_node.Start()
    End Sub

    Private Sub timer_reload_node_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles timer_reload_node.Tick
        Try

            Dim request As HttpWebRequest
            Dim response As HttpWebResponse = Nothing
            Dim reader As StreamReader
            request = DirectCast(WebRequest.Create("https://www.lazstatement.com/auto-node-chia"), HttpWebRequest)

            response = DirectCast(request.GetResponse(), HttpWebResponse)
            reader = New StreamReader(response.GetResponseStream())

            Dim rawresp As String
            rawresp = reader.ReadToEnd()
            datajson = rawresp
            If datajson <> Nothing Then
                Dim jResults As Object = JObject.Parse(rawresp)
                Dim total_ip = jResults("count").ToString
                FlatLabel3.Text = "Ready (" & total_ip & " Node)"
                FlatLabel3.ForeColor = Color.Lime
            Else
                FlatLabel3.Text = "Not Ready (Please Re-Load Node)"
                FlatLabel3.ForeColor = Color.DarkOrange
            End If
        Catch ex As Exception
        End Try
    End Sub
    Private pOutput As String
    Private pError As String
    Public Function CountCharacter(ByVal value As String, ByVal ch As Char) As Integer
        Dim cnt As Integer = 0
        For Each c As Char In value
            If c = ch Then
                cnt += 1
            End If
        Next
        Return cnt
    End Function
    Private Sub get_count_node()
        Try
            chia_ver = FlatTextBox1.Text
            chia_dir = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) & "\chia-blockchain\app-" & chia_ver

            Dim mProcess As New Process
            mProcess.StartInfo.FileName = chia_dir & "\resources\app.asar.unpacked\daemon\chia.exe"
            mProcess.StartInfo.Arguments = "show -c"
            mProcess.StartInfo.RedirectStandardOutput = True
            mProcess.StartInfo.RedirectStandardError = True
            mProcess.StartInfo.UseShellExecute = False
            mProcess.StartInfo.CreateNoWindow = True

            mProcess = Process.Start(mProcess.StartInfo)

            pOutput = mProcess.StandardOutput.ReadToEnd
            pError = mProcess.StandardError.ReadToEnd

            Dim count As Integer
            count = CountCharacter(pOutput, "FULL_NODE")
            Control.CheckForIllegalCrossThreadCalls = False
            FlatLabel6.Text = count
            mProcess.CloseMainWindow()
            mProcess.Close()

        Catch ex As Exception

        End Try
    End Sub

    Private Sub timer_check_nodeonline_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles timer_check_nodeonline.Tick
        Dim autocheck_nodeonline As New Threading.Thread(AddressOf get_count_node)
        CheckForIllegalCrossThreadCalls = False
        autocheck_nodeonline.Start()
    End Sub
    Private Function IsPortOpen(ByVal Host As String, ByVal PortNumber As Integer)

        Dim clientSocket As System.Net.Sockets.TcpClient = New System.Net.Sockets.TcpClient


        Try
            Dim timeStampstart As DateTime = DateTime.Now
            clientSocket.Connect(Host, PortNumber)
            clientSocket.ReceiveTimeout = 100
            clientSocket.SendTimeout = 100
            Dim timeStampend As DateTime = DateTime.Now
            Dim Result As TimeSpan = timeStampend - timeStampstart
            clientSocket.Close()
            Dim returnlist As New List(Of String)
            returnlist.Add("True")
            returnlist.Add(Str(Result.TotalMilliseconds))
            Return returnlist
        Catch ex As SocketException
            Dim returnlist As New List(Of String)
            returnlist.Add("False")
            Return returnlist
        Finally
            If Not clientSocket Is Nothing Then
                clientSocket.Close()
            End If
        End Try



    End Function
    Dim data_fromfile As String
    Dim data_fromfile_local As String
    Dim select_file As String = "No"
    Private Sub FlatButton4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FlatButton4.Click
        Try

            Dim oReader As StreamReader

            OpenFileDialog1.CheckFileExists = True
            OpenFileDialog1.CheckPathExists = True
            OpenFileDialog1.DefaultExt = "txt"
            OpenFileDialog1.FileName = ""
            OpenFileDialog1.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*"
            OpenFileDialog1.Multiselect = False

            If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
                oReader = New StreamReader(OpenFileDialog1.FileName, True)
                data_fromfile_local = OpenFileDialog1.FileName
                data_fromfile = oReader.ReadToEnd
                Dim lines() As String = IO.File.ReadAllLines(OpenFileDialog1.FileName)
                'MsgBox(lines)
                For Each i As String In lines
                    If i.Contains(":") Then
                        select_file = "Yes"
                    Else
                        data_fromfile = ""
                        MessageBox.Show("The file format is not valid" & vbCrLf & "Example: 5.49.24.94:8444", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If

                    Exit For
                Next
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub run_node_fromfile_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles run_node_fromfile.Tick
        If status_run = "No" Then
            If select_file = "Yes" Then
                status_run = "Yes"
                FlatLabel3.Text = "Working.."
                FlatLabel3.ForeColor = Color.Cyan
                Dim run_nodes As New Threading.Thread(AddressOf get_node_fromlfile)
                CheckForIllegalCrossThreadCalls = False
                run_nodes.Start()
                FlatButton1.Enabled = False
                FlatButton2.Enabled = True
                FlatTextBox1.Enabled = False
                FlatButton3.Enabled = False
                FlatLabel4.Text = "Connected 0"
                FlatLabel5.Text = "Connect failed 0"
                My.Settings.chia_ver = FlatTextBox1.Text
                My.Settings.Save()
                My.Settings.Reload()

            ElseIf select_file = "No" Then
                run_node_fromfile.Stop()
            End If
        End If
    End Sub
End Class