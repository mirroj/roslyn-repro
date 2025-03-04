using Microsoft.CodeAnalysis;

namespace MyGenerator;

[Generator]
public class MyGenerator : IIncrementalGenerator
{
    public void Initialize(IncrementalGeneratorInitializationContext context)
    {

        INamedTypeSymbol? classSymbol = null;
        classSymbol?.GetAttributes();
    }
}
