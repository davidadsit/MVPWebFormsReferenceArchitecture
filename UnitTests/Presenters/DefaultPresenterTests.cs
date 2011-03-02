using Moq;
using NUnit.Framework;
using Services.Services;
using WebApplicationLogic.Presenters;
using WebApplicationLogic.Views;

namespace UnitTests.Presenters
{
	[TestFixture]
	public class DefaultPresenterTests
	{
		[SetUp]
		public void SetUp()
		{
			_viewMock = new Mock<IDefaultView>();
			_userStateMock = new Mock<IUserState>();
			_presenter = new DefaultPresenter(_viewMock.Object, _userStateMock.Object);
		}

		[TearDown]
		public void TearDown()
		{
			_viewMock.Verify();
			_userStateMock.Verify();
		}

		private Mock<IDefaultView> _viewMock;
		private DefaultPresenter _presenter;
		private Mock<IUserState> _userStateMock;

		[Test]
		public void HandlePageLoad_GetsUserIdFromUserSessionState()
		{
			_userStateMock
				.Setup(x => x.UserId)
				.Returns("Blue")
				.Verifiable();

			_presenter.HandlePageLoad();
		}

		[Test]
		public void HandlePageLoad_SetsTheLogoutLinkVisibilityToFalseOnTheView_WhenUserIdIsEmpty()
		{
			_userStateMock
				.Setup(x => x.UserId)
				.Returns(string.Empty);
			_viewMock
				.SetupSet(x => x.LogoutLinkVisibility = false)
				.Verifiable();

			_presenter.HandlePageLoad();
		}

		[Test]
		public void HandlePageLoad_SetsTheLogoutLinkVisibilityToTrueOnTheView_WhenUserIdIsSet()
		{
			_userStateMock
				.Setup(x => x.UserId)
				.Returns("Blue");
			_viewMock
				.SetupSet(x => x.LogoutLinkVisibility = true)
				.Verifiable();

			_presenter.HandlePageLoad();
		}

		[Test]
		public void HandlePageLoad_SetsTheUserIdOnTheView_WhenUserIdIsEmpty()
		{
			_userStateMock
				.Setup(x => x.UserId)
				.Returns(string.Empty);
			_viewMock
				.SetupSet(x => x.UserIdDisplay = string.Empty)
				.Verifiable();

			_presenter.HandlePageLoad();
		}

		[Test]
		public void HandlePageLoad_SetsTheUserIdOnTheView_WhenUserIdIsSet()
		{
			_userStateMock
				.Setup(x => x.UserId)
				.Returns("Blue");
			_viewMock
				.SetupSet(x => x.UserIdDisplay = "Logged in as: Blue")
				.Verifiable();

			_presenter.HandlePageLoad();
		}
	}
}