﻿Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports DevExpress.Persistent.BaseImpl
Imports DevExpress.Persistent.Base
Imports DevExpress.Xpo
Namespace Solution43.Module.BusinessObjects
    <DefaultClassOptions> _
    Public Class Contact
        Inherits Person

        Public Sub New(ByVal session As DevExpress.Xpo.Session)
            MyBase.New(session)

        End Sub
    End Class
End Namespace
