﻿[UsesVerify]
public class ConfigTests
{
    [Fact]
    public Task Parsing()
    {
        var context = ContextLoader.Load(@".\ConfigImport.yaml");
        return Verify(context);
    }
}