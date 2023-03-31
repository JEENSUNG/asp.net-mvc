Imports System.ComponentModel.DataAnnotations
Imports System.Data.Entity
Imports Newtonsoft.Json.Serialization

Public Class Courses
    <Key>
    Property Cor_Idx As Long

    <Required, MinLength(2, ErrorMessage:="최소 2자는 입력되어야 합니다."), MaxLength(20, ErrorMessage:="최대 20자 까지만 작성 가능합니다."), RegularExpression("^[a-zA-Z가-힣]*$", ErrorMessage:="영어 또는 한글만 작성할 수 있습니다.")>
    <Display(Name:="과목명")>
    Property Cor_Name As String

    <Display(Name:="교수")>
    <Required, MinLength(2, ErrorMessage:="최소 2자는 입력되어야 합니다."), MaxLength(20, ErrorMessage:="최대 20자 까지만 작성 가능합니다."), RegularExpression("^[a-zA-Z가-힣]*$", ErrorMessage:="영어 또는 한글만 작성할 수 있습니다.")>
    Property Cor_Professor As String

    <Display(Name:="요일")>
    <Required, MinLength(2, ErrorMessage:="최소 2자는 입력되어야 합니다."), MaxLength(20, ErrorMessage:="최대 20자 까지만 작성 가능합니다."), RegularExpression("^[a-zA-Z가-힣]*$", ErrorMessage:="영어 또는 한글만 작성할 수 있습니다.")>
    Property Cor_Day As String

    <Display(Name:="시작 시간")>
    <Required, Range(1, Integer.MaxValue), RegularExpression("^[0-9]*$", ErrorMessage:="숫자로만 입력 가능합니다.")>
    Property Cor_StartTime As Integer

    <Display(Name:="종료 시간")>
    <Required, Range(1, Integer.MaxValue), RegularExpression("^[0-9]*$", ErrorMessage:="숫자로만 입력 가능합니다.")>
    Property Cor_EndTime As Integer

    <Display(Name:="인원 제한수")>
    <Required, Range(1, 45), RegularExpression("^[0-9]*$", ErrorMessage:="최대 45까지 입력 가능합니다.")>
    Property Cor_Number As Integer

    <DataType(DataType.Date)>
    <DisplayFormat(DataFormatString:="{0:yyyy-MM-dd}", ApplyFormatInEditMode:=True)>
    <Required>
    Property Cor_Created_Date As DateTime

    <DataType(DataType.Date)>
    <DisplayFormat(DataFormatString:="{0:yyyy-MM-dd}", ApplyFormatInEditMode:=True)>
    <Required>
    Property Cor_Modified_Date As DateTime

    <Display(Name:="소개")>
    <Required, MinLength(2, ErrorMessage:="최소 2자는 입력되어야 합니다."), MaxLength(20, ErrorMessage:="최대 20자 까지만 작성 가능합니다."), RegularExpression("^[a-zA-Z가-힣]*$", ErrorMessage:="영어 또는 한글만 작성할 수 있습니다.")>
    Property Cor_Description As String

    <Display(Name:="학점")>
    <Required, Range(1, 3), RegularExpression("^[0-9]*$", ErrorMessage:="최대 45까지 입력 가능합니다.")>
    Property Cor_Credit As Integer

    <Required, MinLength(1, ErrorMessage:="최소 1자는 입력되어야 합니다."), MaxLength(2, ErrorMessage:="최대 2자 까지만 작성 가능합니다."), RegularExpression("^[a-zA-Z가-힣]*$", ErrorMessage:="한글만 작성할 수 있습니다.")>
    <Display(Name:="전공/교양")>
    Property Cor_Subject As String

    <Required, DefaultSettingValue("false")>
    Property Cor_Updated As Boolean

    <Required, DefaultSettingValue("false")>
    Property Cor_IsValid As Boolean
End Class
