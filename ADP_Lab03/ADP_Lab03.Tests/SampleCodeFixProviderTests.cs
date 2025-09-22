using System.Threading.Tasks;
using Xunit;
using Verifier =
    Microsoft.CodeAnalysis.CSharp.Testing.XUnit.CodeFixVerifier<ADP_Lab03.SampleSyntaxAnalyzer,
        ADP_Lab03.SampleCodeFixProvider>;

namespace ADP_Lab03.Tests;

public class SampleCodeFixProviderTests
{
    [Fact]
    public async Task ClassWithMyCompanyTitle_ReplaceWithCommonKeyword()
    {
        const string text = @"
public class MyCompanyClass
{
}
";

        const string newText = @"
public class CommonClass
{
}
";

        var expected = Verifier.Diagnostic()
            .WithLocation(2, 14)
            .WithArguments("MyCompanyClass");
        await Verifier.VerifyCodeFixAsync(text, expected, newText).ConfigureAwait(false);
    }
}