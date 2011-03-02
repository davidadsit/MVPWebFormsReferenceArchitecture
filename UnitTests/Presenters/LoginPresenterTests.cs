using Moq;
using NUnit.Framework;
using Services.Services;
using WebApplicationLogic.Presenters;
using WebApplicationLogic.Views;

namespace UnitTests.Presenters
{
	[TestFixture]
	public class LoginPresenterTests
	{
		[SetUp]
		public void SetUp()
		{
			_viewMock = new Mock<ILoginView>();
			_userStateMock = new Mock<IUserState>();
			_presenter = new LoginPresenter(_viewMock.Object, _userStateMock.Object);
		}

		[TearDown]
		public void TearDown()
		{
			_viewMock.Verify();
			_userStateMock.Verify();
		}

		private Mock<ILoginView> _viewMock;
		private LoginPresenter _presenter;
		private Mock<IUserState> _userStateMock;

		[Test]
		public void HandlePageLoad_GetsUserIdFromView()
		{
			_viewMock
				.Setup(x => x.GetUserId())
				.Returns("Blue")
				.Verifiable();

			_presenter.HandlePageLoad();
		}

		[Test]
		public void HandlePageLoad_RedirectsToDefault()
		{
			_viewMock
				.Setup(x => x.GetUserId())
				.Returns("Blue");
			_viewMock
				.Setup(x => x.RedirectToDefault())
				.Verifiable();

			_presenter.HandlePageLoad();
		}

		[Test]
		public void HandlePageLoad_SetsTheUserIdToTheUserState()
		{
			_viewMock
				.Setup(x => x.GetUserId())
				.Returns("Blue");
			_userStateMock
				.SetupSet(x => x.UserId = "Blue")
				.Verifiable();

			_presenter.HandlePageLoad();
		}
	}
}