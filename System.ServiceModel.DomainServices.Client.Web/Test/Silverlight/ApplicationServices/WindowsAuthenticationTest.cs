﻿using System.ServiceModel.DomainServices.Client.Test;
using Microsoft.Silverlight.Testing;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace System.ServiceModel.DomainServices.Client.ApplicationServices.Test
{
    /// <summary>
    /// Tests <see cref="WindowsAuthentication"/> members.
    /// </summary>
    [TestClass]
    public class WindowsAuthenticationTest : UnitTestBase
    {
        [TestMethod]
        [Description("Tests that the Login method throws a NotSupportedException.")]
        public void LoginThrowsNotSupported()
        {
            AuthenticationDomainContext mock = new AuthenticationDomainContext();
            WindowsAuthentication service = new WindowsAuthentication();

            service.DomainContext = mock;

            ExceptionHelper.ExpectException<NotSupportedException>(
                () => service.Login(null));
        }

        [TestMethod]
        [Description("Tests that the Logout method throws a NotSupportedException.")]
        public void LogoutThrowsNotSupported()
        {
            AuthenticationDomainContext mock = new AuthenticationDomainContext();
            WindowsAuthentication service = new WindowsAuthentication();

            service.DomainContext = mock;

            ExceptionHelper.ExpectException<NotSupportedException>(
                () => service.Logout(false));
        }
    }
}