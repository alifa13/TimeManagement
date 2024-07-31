// See https://aka.ms/new-console-template for more information
using TimeManagement.Data;
using TimeManagement.Data.DL;
using TimeManagement.Data.DTOs;

Console.WriteLine("Hello, World!");

//var result = new CustomerDL().CustomerSet(new TimeManagement.Data.DTOs.CustomerDTO
//{
//    CustomerId = 0,
//    CustomerFirstName = "علی",
//    CustomerLastName = "فرشی زاده",
//    MobileNumber = "09134000000",
//    TelNumber = "253000000",
//    Address = "qom",
//});

//var result1 = new ProcessDL().ProcessReport(new TimeManagement.Data.DTOs.ProcessReportFilterDTO());

var d = new StuffDTO
{
	Title = "ketab"
};

Console.WriteLine(d.StuffId);

