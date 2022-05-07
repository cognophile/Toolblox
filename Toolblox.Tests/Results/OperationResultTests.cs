using System;
using Cognophile.Toolblox.Blocks.Results;
using Cognophile.Toolblox.Tests.TestUtilities;
using NUnit.Framework;
using Toolblox.Blocks.Results;

namespace Toolblox.Tests.Results
{
    [TestFixture]
    public class OperationResultTests
    {
        #region Test Configuration
        private OperationResult<FakeEntity> _subject;

        private OperationResult<FakeEntity> ConfigureSubject()
        {
            return new OperationResult<FakeEntity>();
        }
        #endregion

        [SetUp]
        public void SetUp()
        {
            _subject = ConfigureSubject();
        }

        [TearDown]
        public void TearDown()
        {
            _subject = null;
        }

        [Test]
        public void Class_WhenInstantiated_ThenExpectedInterfaceImplemented()
        {
            Assert.That(_subject, Is.InstanceOf<IOperationResult<FakeEntity>>());
        }

        [Test]
        public void Class_WhenInstantiated_ThenExpectedSuperClassImplemented()
        {
            Assert.That(_subject, Is.InstanceOf<OperationResultBase<FakeEntity>>());
        }

        [Test]
        public void Class_WhenInstantiated_ThenExpectedContentPropertyFound()
        {
            Assert.That(_subject, Has.Property("Content"));
        }

        [Test]
        public void Class_WhenInstantiated_ThenExpectedCodePropertyFound()
        {
            Assert.That(_subject, Has.Property("Code"));
        }

        [Test]
        public void Class_WhenInstantiated_ThenExpectedSuccessPropertyFound()
        {
            Assert.That(_subject, Has.Property("Success"));
        }

        [Test]
        public void Class_WhenInstantiated_ThenExpectedMessagePropertyFound()
        {
            Assert.That(_subject, Has.Property("Message"));
        }

        [Test]
        public void Class_WhenInstantiated_ThenExpectedExceptionPropertyFound()
        {
            Assert.That(_subject, Has.Property("Exception"));
        }

        [Test]
        public void Class_WhenInstantiated_ThenExpectedStatePropertyFound()
        {
            Assert.That(_subject, Has.Property("State"));
        }

        [Test]
        public void Class_WhenInstantiatedWithException_ThenExpectedPropertySet()
        {
            _subject = new OperationResult<FakeEntity>(new Exception("An Exception"));

            Assert.That(_subject.Exception.Message, Is.EqualTo("An Exception"));
        }

        [Test]
        public void Class_WhenInstantiatedWithTrueSuccess_ThenExpectedPropertySet()
        {
            _subject = new OperationResult<FakeEntity>(true);

            Assert.That(_subject.Success, Is.True);
        }

        [Test]
        public void Class_WhenInstantiatedWithTrueSuccess_ThenExpectedStateSet()
        {
            _subject = new OperationResult<FakeEntity>(true);

            Assert.That(_subject.State, Is.EqualTo(OperationResultState.Success));
        }

        [Test]
        public void Class_WhenInstantiatedWithFalseSuccess_ThenExpectedPropertySet()
        {
            _subject = new OperationResult<FakeEntity>(false);

            Assert.That(_subject.Success, Is.False);
        }

        [Test]
        public void Class_WhenInstantiatedWithFalseSuccess_ThenExpectedStateSet()
        {
            _subject = new OperationResult<FakeEntity>(false);

            Assert.That(_subject.State, Is.EqualTo(OperationResultState.Failure));
        }

        [Test]
        public void Class_WhenInstantiatedWithSuccessAndCode_ThenExpectedPropertySet()
        {
            _subject = new OperationResult<FakeEntity>(true, code: 123);

            Assert.That(_subject.Success, Is.True);
            Assert.That(_subject.Code, Is.EqualTo(123));
        }

        [Test]
        public void Class_WhenInstantiatedWithSuccessAndMessage_ThenExpectedPropertySet()
        {
            _subject = new OperationResult<FakeEntity>(true, message: "Example message");

            Assert.That(_subject.Success, Is.True);
            Assert.That(_subject.Message, Is.EqualTo("Example message"));
        }

        [Test]
        public void Class_WhenInstantiatedWithAllArguments_ThenExpectedPropertySet()
        {
            _subject = new OperationResult<FakeEntity>(true, code: 123, message: "Example message");

            Assert.That(_subject.Success, Is.True);
            Assert.That(_subject.Code, Is.EqualTo(123));
            Assert.That(_subject.Message, Is.EqualTo("Example message"));
        }

        [Test]
        public void State_WhenOperationIsSuccessful_ThenExpectedStateReturned()
        {
            _subject = new OperationResult<FakeEntity>(success: true);

            Assert.That(_subject.State, Is.EqualTo(OperationResultState.Success));
        }

        [Test]
        public void State_WhenOperationIsFailure_ThenExpectedStateReturned()
        {
            _subject = new OperationResult<FakeEntity>(success: false);

            Assert.That(_subject.State, Is.EqualTo(OperationResultState.Failure));
        }

        [Test]
        public void State_WhenOperationHasException_ThenExpectedStateReturned()
        {
            _subject = new OperationResult<FakeEntity>(new Exception("An Exception"));

            Assert.That(_subject.State, Is.EqualTo(OperationResultState.Exception));
        }

        [Test]
        public void State_WhenOperationIsDefault_ThenExpectedStateReturned()
        {
            _subject = new OperationResult<FakeEntity>();

            var actual = _subject.State;

            Assert.That(actual, Is.EqualTo(OperationResultState.None));
        }

        [Test]
        public void WithSuccess_WhenCalled_ThenExpectedTypeReturned()
        {
            _subject = new OperationResult<FakeEntity>();

            var actual = _subject.WithSuccess();

            Assert.That(actual, Is.InstanceOf<IOperationResult<FakeEntity>>());
        }

        [Test]
        public void WithSuccess_WhenCalled_ThenExpectedSuccessStateReturned()
        {
            _subject = new OperationResult<FakeEntity>();

            var actual = _subject.WithSuccess();

            Assert.That(actual.HasSucceeded(), Is.True);
        }

        [Test]
        public void WithSuccess_WhenCalled_ThenExpectedStateNotFailureReturned()
        {
            _subject = new OperationResult<FakeEntity>();

            var actual = _subject.WithSuccess();

            Assert.That(actual.HasFailed(), Is.False);
        }

        [Test]
        public void WithSuccess_WhenCalledWithCode_ThenExpectedStateReturned()
        {
            _subject = new OperationResult<FakeEntity>();

            var actual = _subject.WithSuccess(201);

            Assert.That(actual.HasCode(), Is.True);
        }

        [Test]
        public void WithSuccess_WhenCalledWithMessage_ThenExpectedStateReturned()
        {
            _subject = new OperationResult<FakeEntity>();

            var actual = _subject.WithSuccess(message: "Example");

            Assert.That(actual.HasMessage(), Is.True);
        }

        [Test]
        public void WithSuccess_WhenCalledWithCodeAndMessage_ThenExpectedStateReturned()
        {
            _subject = new OperationResult<FakeEntity>();

            var actual = _subject.WithSuccess(201, "Example");

            Assert.That(actual.HasCode(), Is.True);
            Assert.That(actual.HasMessage(), Is.True);
        }

        [Test]
        public void WithFailure_WhenCalled_ThenExpectedTypeReturned()
        {
            _subject = new OperationResult<FakeEntity>();

            var actual = _subject.WithFailure();

            Assert.That(actual, Is.InstanceOf<IOperationResult<FakeEntity>>());
        }

        [Test]
        public void WithFailure_WhenCalled_ThenExpectedStateReturned()
        {
            _subject = new OperationResult<FakeEntity>();

            var actual = _subject.WithFailure();

            Assert.That(actual.HasFailed(), Is.True);
        }

        [Test]
        public void WithFailure_WhenCalled_ThenExpectedStateNotSucceededReturned()
        {
            _subject = new OperationResult<FakeEntity>();

            var actual = _subject.WithFailure();

            Assert.That(actual.HasSucceeded(), Is.False);
        }

        [Test]
        public void WithFailure_WhenCalledWithCode_ThenExpectedStateReturned()
        {
            _subject = new OperationResult<FakeEntity>();

            var actual = _subject.WithFailure(404);

            Assert.That(actual.HasCode(), Is.True);
        }

        [Test]
        public void WithFailure_WhenCalledWithMessage_ThenExpectedStateReturned()
        {
            _subject = new OperationResult<FakeEntity>();

            var actual = _subject.WithFailure(message: "Example");

            Assert.That(actual.HasMessage(), Is.True);
        }

        [Test]
        public void WithFailure_WhenCalledWithCodeAndMessage_ThenExpectedStateReturned()
        {
            _subject = new OperationResult<FakeEntity>();

            var actual = _subject.WithFailure(404, "Example");

            Assert.That(actual.HasCode(), Is.True);
            Assert.That(actual.HasMessage(), Is.True);
        }

        [Test]
        public void WithContent_WhenCalled_ThenExpectedTypeReturned()
        {
            _subject = new OperationResult<FakeEntity>();

            var actual = _subject.WithContent(new FakeEntity());

            Assert.That(actual, Is.InstanceOf<IOperationResult<FakeEntity>>());
        }

        [Test]
        public void WithContent_WhenCalled_ThenExpectedStateReturned()
        {
            _subject = new OperationResult<FakeEntity>();

            var actual = _subject.WithContent(new FakeEntity());

            Assert.That(actual.HasContent(), Is.True);
        }

        [Test]
        public void WithContent_WhenCalledWithNullArgument_ThenExpectedStateReturned()
        {
            _subject = new OperationResult<FakeEntity>();

            var actual = _subject.WithContent(null);

            Assert.That(actual.HasContent(), Is.False);
        }

        [Test]
        public void WithException_WhenCalled_ThenExpectedTypeReturned()
        {
            _subject = new OperationResult<FakeEntity>();

            var actual = _subject.WithException(new Exception());

            Assert.That(actual, Is.InstanceOf<IOperationResult<FakeEntity>>());
        }

        [Test]
        public void WithException_WhenCalled_ThenExpectedStateReturned()
        {
            _subject = new OperationResult<FakeEntity>();

            var actual = _subject.WithException(new Exception());

            Assert.That(actual.HasException(), Is.True);
        }

        [Test]
        public void WithException_WhenCalledWithNullArgument_ThenExpectedStateReturned()
        {
            _subject = new OperationResult<FakeEntity>();

            var actual = _subject.WithException(null);

            Assert.That(actual.HasException(), Is.False);
        }

        [Test]
        public void HasSucceeded_WhenSuccess_ThenExpectedValueReturned()
        {
            _subject = new OperationResult<FakeEntity>()
            {
                Success = true
            };

            Assert.That(_subject.HasSucceeded(), Is.True);
        }

        [Test]
        public void HasSucceeded_WhenFailed_ThenExpectedValueReturned()
        {
            _subject = new OperationResult<FakeEntity>()
            {
                Success = false
            };

            Assert.That(_subject.HasSucceeded(), Is.False);
        }

        [Test]
        public void HasFailed_WhenSuccess_ThenExpectedValueReturned()
        {
            _subject = new OperationResult<FakeEntity>()
            {
                Success = true
            };

            Assert.That(_subject.HasFailed(), Is.False);
        }

        [Test]
        public void HasFailed_WhenFailed_ThenExpectedValueReturned()
        {
            _subject = new OperationResult<FakeEntity>()
            {
                Success = false
            };

            Assert.That(_subject.HasFailed(), Is.True);
        }

        [Test]
        public void HasCode_WhenValueSet_ThenExpectedValueReturned()
        {
            _subject = new OperationResult<FakeEntity>()
            {
                Code = 200
            };

            Assert.That(_subject.HasCode(), Is.True);
        }

        [Test]
        public void HasCode_WhenValueNotSet_ThenExpectedValueReturned()
        {
            _subject = new OperationResult<FakeEntity>();

            Assert.That(_subject.HasCode(), Is.False);
        }

        [Test]
        public void HasMessage_WhenValueSet_ThenExpectedValueReturned()
        {
            _subject = new OperationResult<FakeEntity>()
            {
                Message = "Example"
            };

            Assert.That(_subject.HasMessage(), Is.True);
        }

        [Test]
        public void HasMessage_WhenValueNotSet_ThenExpectedValueReturned()
        {
            _subject = new OperationResult<FakeEntity>();

            Assert.That(_subject.HasMessage(), Is.False);
        }

        [Test]
        public void HasException_WhenValueSet_ThenExpectedValueReturned()
        {
            _subject = new OperationResult<FakeEntity>()
            {
                Exception = new Exception()
            };

            Assert.That(_subject.HasException(), Is.True);
        }

        [Test]
        public void HasException_WhenValueNotSet_ThenExpectedValueReturned()
        {
            _subject = new OperationResult<FakeEntity>();

            Assert.That(_subject.HasException(), Is.False);
        }

        [Test]
        public void HasContent_WhenValueSet_ThenExpectedValueReturned()
        {
            _subject = new OperationResult<FakeEntity>()
            {
                Content = new FakeEntity()
            };

            Assert.That(_subject.HasContent(), Is.True);
        }

        [Test]
        public void HasContent_WhenValueNotSet_ThenExpectedValueReturned()
        {
            _subject = new OperationResult<FakeEntity>();

            Assert.That(_subject.HasContent(), Is.False);
        }
    }
}
