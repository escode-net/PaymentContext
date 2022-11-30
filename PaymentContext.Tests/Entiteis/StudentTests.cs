using Microsoft.VisualStudio.TestTools.UnitTesting;
using PaymentContext.Domain.Entities;

namespace PaymentContext.Tests.Entiteis;

public class StudentTests
{
    [TestMethod]
    public void StudentTest()
    {
        var student = new Student
                            (
                                "Edson",
                                "Santos",
                                "123",
                                "edson.santos@escode.net"
                            );
    }
}