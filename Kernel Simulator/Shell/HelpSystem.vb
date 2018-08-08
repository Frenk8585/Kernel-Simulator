﻿
'    Kernel Simulator  Copyright (C) 2018  EoflaOE
'
'    This file is part of Kernel Simulator
'
'    Kernel Simulator is free software: you can redistribute it and/or modify
'    it under the terms of the GNU General Public License as published by
'    the Free Software Foundation, either version 3 of the License, or
'    (at your option) any later version.
'
'    Kernel Simulator is distributed in the hope that it will be useful,
'    but WITHOUT ANY WARRANTY; without even the implied warranty of
'    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
'    GNU General Public License for more details.
'
'    You should have received a copy of the GNU General Public License
'    along with this program.  If not, see <https://www.gnu.org/licenses/>.

Public Module HelpSystem

    Public Sub ShowHelp(Optional ByVal command As String = "")

        If (command = "") Then

            'TODO: Color the help system. (0.0.5)
            'TODO: Modification Parser for mods with commands (Help, Commands, and everything).
            If (simHelp = False) Then
                For Each cmd As String In definitions.Keys
                    W("- {0}: ", "neutralText", cmd) : W("{0}", "neutralText", definitions(cmd)) : Console.WriteLine()
                Next
                Wln("* You can use multiple commands using the colon between commands." + vbNewLine + _
                    "* Aliases will be shown in ""showaliases"" on 0.0.5.", "neutralText")
            Else
                Wln(String.Join(", ", availableCommands), "neutralText")
            End If

        ElseIf (command = "adduser") Then

            Wln("Usage: adduser <userName> [password] [confirm]" + vbNewLine + _
                "       adduser: to be prompted about new username and password. (deprecated)", "neutralText")

        ElseIf (command = "alias") Then

            Wln("Usage: alias <rem/add> <alias> <cmd>", "neutralText")

        ElseIf (command = "beep") Then

            Wln("Usage: beep <Frequency:Hz> <Time:Seconds>" + vbNewLine + _
                "       beep: to be prompted about beeping. (deprecated)", "neutralText")

        ElseIf (command = "arginj") Then

            Wln("Usage: arginj [Arguments separated by commas]" + vbNewLine + _
                "       arginj: to be prompted about boot arguments. (deprecated)", "neutralText")

        ElseIf (command = "calc") Then

            Wln("Usage: calc <expression> ...", "neutralText")

        ElseIf (command = "cdir") Then

            Wln("Usage: cdir: to get current directory", "neutralText")

        ElseIf (command = "chdir") Then

            Wln("Usage: chdir <directory> OR ..", "neutralText")

        ElseIf (command = "chhostname") Then

            Wln("Usage: chhostname <HostName>" + vbNewLine + _
                "       chhostname: to be prompted about changing host name. (deprecated)", "neutralText")

        ElseIf (command = "chmotd") Then

            Wln("Usage: chmotd <Message>", "neutralText")

        ElseIf (command = "chmal") Then

            Wln("Usage: chmal <Message>", "neutralText")

        ElseIf (command = "choice") Then

            Wln("Usage: choice <Question> <sets>" + vbNewLine + _
                "       choice: to be prompted about choices. (deprecated)", "neutralText")

        ElseIf (command = "chpwd") Then

            Wln("Usage: chpwd: to be prompted about changing passwords. (deprecated)", "neutralText")

        ElseIf (command = "chusrname") Then

            Wln("Usage: chusrname <oldUserName> <newUserName>" + vbNewLine + _
                "       chusrname: to be prompted about changing usernames. (deprecated)", "neutralText")

        ElseIf (command = "cls") Then

            Wln("Usage: cls: to clear screen.", "neutralText")

        ElseIf (command = "debuglog") Then

            Wln("Usage: debuglog: Shows you debug logs so you can send the log to us.", "neutralText")

        ElseIf (command = "disco") Then

            Wln("Usage: disco: to get a disco effect on the console. True color support will come with GUI console.", "neutralText")

        ElseIf (command = "echo") Then

            Wln("Usage: echo <text>" + vbNewLine + _
                "       echo: to be prompted about text printing. (deprecated)", "neutralText")

        ElseIf (command = "hwprobe") Then

            Wln("Usage: hwprobe: Probes hardware (Only works when the hardware is not probed and hwprobe is not executed).", "neutralText")

        ElseIf (command = "list") Then
            Wln("Usage: list [oneDirectory]" + vbNewLine + _
                "       list: to get current directory.", "neutralText")

        ElseIf (command = "lsnet") Then
            Wln("Usage: lsnet: Lists network information, as well as every computer connected to a network." + vbNewLine + _
                "       Friends of lsnet: lsnettree", "neutralText")

        ElseIf (command = "lsnettree") Then
            Wln("Usage: lsnettree: Lists network information, as well as every computer connected to a network, in a tree form." + vbNewLine + _
                "       Friends of lsnettree: lsnet", "neutralText")

        ElseIf (command = "loadsaver") Then

            Wln("Usage: loadsaver <modNameSS.m>", "neutralText")

        ElseIf (command = "lockscreen") Then

            Wln("Usage: lockscreen: Locks your screen with the password." + vbNewLine + _
                "       Friends of lockscreen: savescreen", "neutralText")

        ElseIf (command = "logout") Then

            Wln("Usage: logout: Logs you out of the user." + vbNewLine + _
                "       Friends of logout: reboot, shutdown", "neutralText")

        ElseIf (command = "md") Then

            Wln("Usage: md <anything>", "neutralText")

        ElseIf (command = "netinfo") Then

            Wln("Usage: netinfo: Get every network information", "neutralText")

        ElseIf (command = "panicsim") Then

            Wln("Usage: panicsim <message> [S/F/D/[C]/U] [RebootTime:Seconds]" + vbNewLine + _
                "       panicsim: to be prompted about panic simulator options. (deprecated)", "neutralText")

        ElseIf (command = "perm") Then

            Wln("Usage: perm <userName> <Admin/Disabled> <Allow/Disallow>" + vbNewLine + _
                "       perm: to be prompted about permission setting. (deprecated)", "neutralText")

        ElseIf (command = "ping") Then

            Wln("Usage: ping <Address> [repeatTimes]" + vbNewLine + _
                "       ping: to get prompted about writing address. (deprecated)", "neutralText")

        ElseIf (command = "rd") Then

            Wln("Usage: rd <directory>", "neutralText")

        ElseIf (command = "read") Then

        Wln("Usage: read <file>" + vbNewLine + _
            "       read: to get prompted about reading file contents. (deprecated)", "neutralText")

        ElseIf (command = "reboot") Then

        Wln("Usage: reboot: Restarts your simulated computer." + vbNewLine + _
            "       Friends of reboot: shutdown, logout", "neutralText")

        ElseIf (command = "reloadconfig") Then

        Wln("Usage: reloadconfig: Reloads the configuration that is changed by the end-user or by tool." + vbNewLine + _
            "       Colors doesn't require a restart, but most of the settings require you to restart.", "neutralText")

        ElseIf (command = "rmuser") Then

        Wln("Usage: rmuser <Username>" + vbNewLine + _
            "       rmuser: to get prompted about removing usernames.", "neutralText")

        ElseIf (command = "savescreen") Then

        Wln("Usage: savescreen: shows you a selected screensaver, while protecting your screen from burn outs." + vbNewLine + _
            "       Friends of savescreen: lockscreen", "neutralText")

        ElseIf (command = "scical") Then

        Wln("Usage: scical <expression1|pi|e> <+|-|*|/|%> <expression2|pi|e> ..." + vbNewLine + _
            "       scical <sqrt|tan|sin|cos> <number>", "neutralText")

        ElseIf (command = "setcolors") Then

        Wln("Usage: setcolors <inputColor/def> <licenseColor/def> <contKernelErrorColor/def> <uncontKernelErrorColor/def> <hostNameShellColor/def> <userNameShellColor/def> <backgroundColor/def> <neutralTextColor/def>" + vbNewLine + _
            "       setcolors: to get prompted about setting colors. (deprecated)" + vbNewLine + _
            "       Friends of setcolors: setthemes", "neutralText")

        ElseIf (command = "setsaver") Then

        Wln("Usage: setsaver <modNameSS.m>", "neutralText")

        ElseIf (command = "setthemes") Then

        Wln("Usage: setthemes <Theme>" + vbNewLine + _
            "       setthemes: to get prompted about setting themes. (deprecated)" + vbNewLine + _
            "       Friends of setthemes: setcolors", "neutralText")

        ElseIf (command = "showmotd") Then

        Wln("Usage: showmotd: Shows your current Message Of The Day.", "neutralText")

        ElseIf (command = "showtd") Then

        Wln("Usage: showtd: Shows the date and time.", "neutralText")

        ElseIf (command = "showtdzone") Then

        Wln("Usage: showtdzone: Shows the date and time in zones.", "neutralText")

        ElseIf (command = "shutdown") Then

        Wln("Usage: shutdown: Shuts down your simulated computer." + vbNewLine + _
            "       Friends of shutdown: reboot, logout", "neutralText")

        ElseIf (command = "sysinfo") Then

        Wln("Usage: sysinfo: Shows system information and versions." + vbNewLine + _
            "       Friends of sysinfo: version", "neutralText")

        ElseIf (command = "unitconv") Then

        Wln("Usage: unitconv <sourceUnit> <targetUnit> <value>" + vbNewLine + _
            "Units: B, KB, MB, GB, TB, Bits, Octal, Binary, Decimal, Hexadecimal, mm, cm, m, km, Fahrenheit, Celsius, Kelvin, " + _
            "Reaumur, Romer, Delisle, Rankine, j, kj, m/s, km/h, cm/ms, Kilograms, Grams, Tons, Kilotons, Megatons, kn, n, Hz, kHz, MHz, " + _
            "GHz, Number (source only), Money (target only), Percent (target only), Centivolts, Volts, Kilovolts, Watts, Kilowatts, " + _
            "Milliliters, Liters, Kiloliters, Gallons, Ounces, Feet, Inches, Yards and Miles.", "neutralText")

        ElseIf (command = "version") Then

        Wln("Usage: version: Shows kernel version." + vbNewLine + _
            "       Friends of version: sysinfo", "neutralText")

        End If

    End Sub

End Module