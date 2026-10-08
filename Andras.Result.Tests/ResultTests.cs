using Andras.Result.Errors;

namespace Andras.Result.Tests
{
    public class ResultTests
    {
        [Fact]
        public void Success_ShouldBeSuccessful()
        {
            var result = Result.Success();

            Assert.True(result.IsSuccess);
            Assert.False(result.IsFailure);
            Assert.Null(result.Error);
        }

        [Fact]
        public void Failure_ShouldContainError()
        {
            var error = Error.NotFound(
                "AdUser.NotFound",
                "Usuário não encontrado.");

            var result = Result.Failure(error);

            Assert.False(result.IsSuccess);
            Assert.True(result.IsFailure);
            Assert.Equal(error, result.Error);
        }

        [Fact]
        public void GenericSuccess_ShouldContainValue()
        {
            var result = Result<string>.Success("Andras");

            Assert.True(result.IsSuccess);
            Assert.Equal("Andras", result.Value);
            Assert.Null(result.Error);
        }
    }
}
