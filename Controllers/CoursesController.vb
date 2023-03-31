Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Data.Entity
Imports System.Linq
Imports System.Net
Imports System.Web
Imports System.Web.Mvc
Imports Enrollment
Imports Enrollment.Data

Namespace Controllers
    Public Class CoursesController
        Inherits Controller

        Private db As New EFDbContext

        ' GET: Courses
        Function Index(professor As String, keyword As String) As ActionResult
            Dim List As New List(Of String)
            Dim professors = From m In db.Courses
                             Order By m.Cor_Professor
                             Select m.Cor_Professor
            List.AddRange(professors.Distinct)
            ViewBag.professor = New SelectList(List)
            Dim courses = From m In db.Courses
                          Select m
            If Not String.IsNullOrEmpty(keyword) Then
                courses = courses.Where(Function(p) p.Cor_Name.Contains(keyword))
            End If
            If Not String.IsNullOrEmpty(professor) Then
                courses = courses.Where(Function(p) p.Cor_Professor = professor)
            End If
            Return View(courses)
        End Function

        ' GET: Courses/Details/5
        Function Details(ByVal id As Long?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim courses As Courses = db.Courses.Find(id)
            If IsNothing(courses) Then
                Return HttpNotFound()
            End If
            Return View(courses)
        End Function

        ' GET: Courses/Create
        Function Create() As ActionResult
            Dim List As New List(Of String) From {
                "전공",
                "교양"
            }
            ViewBag.List = List
            Return View()
        End Function

        ' POST: Courses/Create
        '초과 게시 공격으로부터 보호하려면 바인딩하려는 특정 속성을 사용하도록 설정하세요. 
        '자세한 내용은 https://go.microsoft.com/fwlink/?LinkId=317598을(를) 참조하세요.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Create(<Bind(Include:="Cor_Name,Cor_Professor,Cor_Day,Cor_StartTime,Cor_EndTime,Cor_Number,Cor_Description,Cor_Credit,Cor_Subject")> ByVal courses As Courses) As ActionResult
            Console.WriteLine()
            If ModelState.IsValid Then
                courses.Cor_Created_Date = DateTime.Now
                courses.Cor_Modified_Date = courses.Cor_Created_Date
                db.Courses.Add(courses)
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If
            Return View(courses)
        End Function

        ' GET: Courses/Edit/5
        Function Edit(ByVal id As Long?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim courses As Courses = db.Courses.Find(id)
            If IsNothing(courses) Then
                Return HttpNotFound()
            End If
            Return View(courses)
        End Function

        ' POST: Courses/Edit/5
        '초과 게시 공격으로부터 보호하려면 바인딩하려는 특정 속성을 사용하도록 설정하세요. 
        '자세한 내용은 https://go.microsoft.com/fwlink/?LinkId=317598을(를) 참조하세요.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Edit(<Bind(Include:="Cor_Idx,Cor_Name,Cor_Professor,Cor_Day,Cor_StartTime,Cor_EndTime,Cor_Number,Cor_Date,Cor_Description,Cor_Credit,Cor_Subject,Cor_Updated,Cor_IsValid")> ByVal courses As Courses) As ActionResult
            If ModelState.IsValid Then
                db.Entry(courses).State = EntityState.Modified
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If
            Return View(courses)
        End Function

        ' GET: Courses/Delete/5
        Function Delete(ByVal id As Long?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim courses As Courses = db.Courses.Find(id)
            If IsNothing(courses) Then
                Return HttpNotFound()
            End If
            Return View(courses)
        End Function

        ' POST: Courses/Delete/5
        <HttpPost()>
        <ActionName("Delete")>
        <ValidateAntiForgeryToken()>
        Function DeleteConfirmed(ByVal id As Long) As ActionResult
            Dim courses As Courses = db.Courses.Find(id)
            db.Courses.Remove(courses)
            db.SaveChanges()
            Return RedirectToAction("Index")
        End Function

        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If (disposing) Then
                db.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub
    End Class
End Namespace
