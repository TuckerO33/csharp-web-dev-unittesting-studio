namespace BalancedBracketsTests;
using BalancedBrackets;
[TestClass]
public class BalancedBracketsTests
{   [TestMethod]
    // TODO: Add tests to this file.
    public void OnlyBracketsReturnsTrue() {
        Assert.IsTrue(BalancedBrackets.HasBalancedBrackets("[]"));
    }

    [TestMethod]
    public void EmptyStringReturnsTrue() {
        Assert.IsTrue(BalancedBrackets.HasBalancedBrackets(""));
    }

    [TestMethod]
    public void LaunchCodeInBracketsReturnsTrue() {
        Assert.IsTrue(BalancedBrackets.HasBalancedBrackets("[LaunchCode]"));
    }

    [TestMethod]
    public void LaunchCodeWithCodeInBracketsReturnsTrue() {
        Assert.IsTrue(BalancedBrackets.HasBalancedBrackets("Launch[Code]"));
    }

    [TestMethod]
    public void EmptyBracketsPlusLaunchCodeReturnsTrue() {
        Assert.IsTrue(BalancedBrackets.HasBalancedBrackets("[]LaunchCode"));
    }

    [TestMethod]
    public void BackwardBracketsRetrunFalse() {
        Assert.IsFalse(BalancedBrackets.HasBalancedBrackets("]["));
    }

    [TestMethod]
    public void OpenBracketPlusLaunchCodeReturnsFalse() {
        Assert.IsFalse(BalancedBrackets.HasBalancedBrackets("[LaunchCode"));
    }

    [TestMethod]
    public void LaunchPlusCodeInBackwardBracketsReturnsFalse() {
        Assert.IsFalse(BalancedBrackets.HasBalancedBrackets("Launch]Code["));
    }

    [TestMethod]
    public void SingleOpenBracketReturnsFalse() {
        Assert.IsFalse(BalancedBrackets.HasBalancedBrackets("["));
    }

    [TestMethod]
    public void OpenCurlyBracketPlusEmptyBracketsReturnsTrue() {
        Assert.IsTrue(BalancedBrackets.HasBalancedBrackets("{[]"));
    }

    [TestMethod]
    public void EmptyBracketsPlusBackwardsBracketsReturnsFalse() {
        Assert.IsFalse(BalancedBrackets.HasBalancedBrackets("[]]["));
    }

        [TestMethod]
    public void ManyNestedBracketsPlusLaunchCodeReturnsTrue() {
        Assert.IsTrue(BalancedBrackets.HasBalancedBrackets("[[[[[[[[[[[[[[[[[[[[[[[[LaunchCode]]]]]]]]]]]]]]]]]]]]]]]]"));
    }

}