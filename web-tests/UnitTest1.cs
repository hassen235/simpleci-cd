namespace web_tests;

public class RootIntegration
{
    [Fact]
    public async Task Test1Async()
    {

		//arrange
		HttpClient client=new();

		//act
		var result=await client.GetAsync("http://localhost:8080/");


		//assert
		Assert.True(result.IsSuccessStatusCode);
		Assert.Equal("Hello World!",await result.Content.ReadAsStringAsync(default));
    }
}
