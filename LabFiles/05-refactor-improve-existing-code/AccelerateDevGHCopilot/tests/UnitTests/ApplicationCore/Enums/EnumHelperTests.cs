using Library.ApplicationCore.Enums;

namespace Library.UnitTests.ApplicationCore.Enums;

public class EnumHelperTests
{
    [Fact]
    public void GetDescription_LoanExtensionStatus_ReturnsDescription()
    {
        Assert.Equal(
            "Cannot extend book loan as it already has expired. Return the book instead.",
            EnumHelper.GetDescription(LoanExtensionStatus.LoanExpired));
    }

    [Fact]
    public void GetDescription_LoanReturnStatus_ReturnsDescription()
    {
        Assert.Equal(
            "Cannot return book as the book is already returned.",
            EnumHelper.GetDescription(LoanReturnStatus.AlreadyReturned));
    }

    [Fact]
    public void GetDescription_MembershipRenewalStatus_ReturnsDescription()
    {
        Assert.Equal(
            "It is too early to renew the membership.",
            EnumHelper.GetDescription(MembershipRenewalStatus.TooEarlyToRenew));
    }

    [Fact]
    public void GetDescription_NullValue_ReturnsEmptyString()
    {
        Assert.Equal(string.Empty, EnumHelper.GetDescription(null!));
    }
}
