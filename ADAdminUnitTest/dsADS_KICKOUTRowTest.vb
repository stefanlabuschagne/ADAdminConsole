﻿Imports System.Data

Imports Microsoft.VisualStudio.TestTools.UnitTesting

Imports ADAdminDotNet



'''<summary>
'''This is a test class for dsADS_KICKOUTRowTest and is intended
'''to contain all dsADS_KICKOUTRowTest Unit Tests
'''</summary>
<TestClass()> _
Public Class dsADS_KICKOUTRowTest


    Private testContextInstance As TestContext

    '''<summary>
    '''Gets or sets the test context which provides
    '''information about and functionality for the current test run.
    '''</summary>
    Public Property TestContext() As TestContext
        Get
            Return testContextInstance
        End Get
        Set(ByVal value As TestContext)
            testContextInstance = Value
        End Set
    End Property

#Region "Additional test attributes"
    '
    'You can use the following additional attributes as you write your tests:
    '
    'Use ClassInitialize to run code before running the first test in the class
    '<ClassInitialize()>  _
    'Public Shared Sub MyClassInitialize(ByVal testContext As TestContext)
    'End Sub
    '
    'Use ClassCleanup to run code after all tests in a class have run
    '<ClassCleanup()>  _
    'Public Shared Sub MyClassCleanup()
    'End Sub
    '
    'Use TestInitialize to run code before running each test
    '<TestInitialize()>  _
    'Public Sub MyTestInitialize()
    'End Sub
    '
    'Use TestCleanup to run code after each test has run
    '<TestCleanup()>  _
    'Public Sub MyTestCleanup()
    'End Sub
    '
#End Region


'''<summary>
'''A test for KICKOUTValue
'''</summary>
<TestMethod()>  _
Public Sub KICKOUTValueTest()
Dim rb As DataRowBuilder = Nothing ' TODO: Initialize to an appropriate value
Dim target As dsADS.KICKOUTRow = New dsADS.KICKOUTRow(rb) ' TODO: Initialize to an appropriate value
Dim expected As Long = 0 ' TODO: Initialize to an appropriate value
    Dim actual As Long
    target.KICKOUTValue = expected
    actual = target.KICKOUTValue
    Assert.AreEqual(expected, actual)
    Assert.Inconclusive("Verify the correctness of this test method.")
End Sub

'''<summary>
'''A test for KICKOUTRow Constructor
'''</summary>
<TestMethod()>  _
Public Sub dsADS_KICKOUTRowConstructorTest()
Dim rb As DataRowBuilder = Nothing ' TODO: Initialize to an appropriate value
    Dim target As dsADS.KICKOUTRow = New dsADS.KICKOUTRow(rb)
    Assert.Inconclusive("TODO: Implement code to verify target")
End Sub
End Class
