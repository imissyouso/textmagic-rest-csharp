/* 
 * TextMagic API
 *
 * No description provided (generated by Swagger Codegen https://github.com/swagger-api/swagger-codegen)
 *
 * OpenAPI spec version: 2
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */


using NUnit.Framework;

using System;
using System.Linq;
using System.IO;
using System.Collections.Generic;
using TextMagicClient.Api;
using TextMagicClient.Model;
using TextMagicClient.Client;
using System.Reflection;
using Newtonsoft.Json;

namespace TextMagicClient.Test
{
    /// <summary>
    ///  Class for testing GetStateResponse
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the model.
    /// </remarks>
    [TestFixture]
    public class GetStateResponseTests
    {
        // TODO uncomment below to declare an instance variable for GetStateResponse
        //private GetStateResponse instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            // TODO uncomment below to create an instance of GetStateResponse
            //instance = new GetStateResponse();
        }

        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of GetStateResponse
        /// </summary>
        [Test]
        public void GetStateResponseInstanceTest()
        {
            // TODO uncomment below to test "IsInstanceOfType" GetStateResponse
            //Assert.IsInstanceOfType<GetStateResponse> (instance, "variable 'instance' is a GetStateResponse");
        }


        /// <summary>
        /// Test the property 'SystemCacheClear'
        /// </summary>
        [Test]
        public void SystemCacheClearTest()
        {
            // TODO unit test for the property 'SystemCacheClear'
        }
        /// <summary>
        /// Test the property 'SystemExit'
        /// </summary>
        [Test]
        public void SystemExitTest()
        {
            // TODO unit test for the property 'SystemExit'
        }
        /// <summary>
        /// Test the property 'SystemAlert'
        /// </summary>
        [Test]
        public void SystemAlertTest()
        {
            // TODO unit test for the property 'SystemAlert'
        }
        /// <summary>
        /// Test the property 'SystemAccountStateChanged'
        /// </summary>
        [Test]
        public void SystemAccountStateChangedTest()
        {
            // TODO unit test for the property 'SystemAccountStateChanged'
        }
        /// <summary>
        /// Test the property 'MessageDeleted'
        /// </summary>
        [Test]
        public void MessageDeletedTest()
        {
            // TODO unit test for the property 'MessageDeleted'
        }
        /// <summary>
        /// Test the property 'MessageIncoming'
        /// </summary>
        [Test]
        public void MessageIncomingTest()
        {
            // TODO unit test for the property 'MessageIncoming'
        }
        /// <summary>
        /// Test the property 'MessageIncomingDeleted'
        /// </summary>
        [Test]
        public void MessageIncomingDeletedTest()
        {
            // TODO unit test for the property 'MessageIncomingDeleted'
        }
        /// <summary>
        /// Test the property 'MessageStateChanged'
        /// </summary>
        [Test]
        public void MessageStateChangedTest()
        {
            // TODO unit test for the property 'MessageStateChanged'
        }
        /// <summary>
        /// Test the property 'MessageBulkEnd'
        /// </summary>
        [Test]
        public void MessageBulkEndTest()
        {
            // TODO unit test for the property 'MessageBulkEnd'
        }
        /// <summary>
        /// Test the property 'MessageWipeEnd'
        /// </summary>
        [Test]
        public void MessageWipeEndTest()
        {
            // TODO unit test for the property 'MessageWipeEnd'
        }
        /// <summary>
        /// Test the property 'MessageSent'
        /// </summary>
        [Test]
        public void MessageSentTest()
        {
            // TODO unit test for the property 'MessageSent'
        }
        /// <summary>
        /// Test the property 'MessageSessionDeleted'
        /// </summary>
        [Test]
        public void MessageSessionDeletedTest()
        {
            // TODO unit test for the property 'MessageSessionDeleted'
        }
        /// <summary>
        /// Test the property 'MessageCacheClear'
        /// </summary>
        [Test]
        public void MessageCacheClearTest()
        {
            // TODO unit test for the property 'MessageCacheClear'
        }
        /// <summary>
        /// Test the property 'MessageIncomingCacheClear'
        /// </summary>
        [Test]
        public void MessageIncomingCacheClearTest()
        {
            // TODO unit test for the property 'MessageIncomingCacheClear'
        }
        /// <summary>
        /// Test the property 'MessageScheduleAdded'
        /// </summary>
        [Test]
        public void MessageScheduleAddedTest()
        {
            // TODO unit test for the property 'MessageScheduleAdded'
        }
        /// <summary>
        /// Test the property 'MessageScheduleStateChanged'
        /// </summary>
        [Test]
        public void MessageScheduleStateChangedTest()
        {
            // TODO unit test for the property 'MessageScheduleStateChanged'
        }
        /// <summary>
        /// Test the property 'MessageScheduleDeleted'
        /// </summary>
        [Test]
        public void MessageScheduleDeletedTest()
        {
            // TODO unit test for the property 'MessageScheduleDeleted'
        }
        /// <summary>
        /// Test the property 'MessageScheduleCacheClear'
        /// </summary>
        [Test]
        public void MessageScheduleCacheClearTest()
        {
            // TODO unit test for the property 'MessageScheduleCacheClear'
        }
        /// <summary>
        /// Test the property 'MessageTemplateCacheClear'
        /// </summary>
        [Test]
        public void MessageTemplateCacheClearTest()
        {
            // TODO unit test for the property 'MessageTemplateCacheClear'
        }
        /// <summary>
        /// Test the property 'CallFinished'
        /// </summary>
        [Test]
        public void CallFinishedTest()
        {
            // TODO unit test for the property 'CallFinished'
        }
        /// <summary>
        /// Test the property 'ChatCreated'
        /// </summary>
        [Test]
        public void ChatCreatedTest()
        {
            // TODO unit test for the property 'ChatCreated'
        }
        /// <summary>
        /// Test the property 'ChatMarkedAsRead'
        /// </summary>
        [Test]
        public void ChatMarkedAsReadTest()
        {
            // TODO unit test for the property 'ChatMarkedAsRead'
        }
        /// <summary>
        /// Test the property 'ChatMuted'
        /// </summary>
        [Test]
        public void ChatMutedTest()
        {
            // TODO unit test for the property 'ChatMuted'
        }
        /// <summary>
        /// Test the property 'ChatUnmuted'
        /// </summary>
        [Test]
        public void ChatUnmutedTest()
        {
            // TODO unit test for the property 'ChatUnmuted'
        }
        /// <summary>
        /// Test the property 'ChatDeleted'
        /// </summary>
        [Test]
        public void ChatDeletedTest()
        {
            // TODO unit test for the property 'ChatDeleted'
        }
        /// <summary>
        /// Test the property 'ChatClosed'
        /// </summary>
        [Test]
        public void ChatClosedTest()
        {
            // TODO unit test for the property 'ChatClosed'
        }
        /// <summary>
        /// Test the property 'ChatReopened'
        /// </summary>
        [Test]
        public void ChatReopenedTest()
        {
            // TODO unit test for the property 'ChatReopened'
        }
        /// <summary>
        /// Test the property 'ChatCacheClear'
        /// </summary>
        [Test]
        public void ChatCacheClearTest()
        {
            // TODO unit test for the property 'ChatCacheClear'
        }
        /// <summary>
        /// Test the property 'ContactAdded'
        /// </summary>
        [Test]
        public void ContactAddedTest()
        {
            // TODO unit test for the property 'ContactAdded'
        }
        /// <summary>
        /// Test the property 'ContactDeleted'
        /// </summary>
        [Test]
        public void ContactDeletedTest()
        {
            // TODO unit test for the property 'ContactDeleted'
        }
        /// <summary>
        /// Test the property 'ContactStateChanged'
        /// </summary>
        [Test]
        public void ContactStateChangedTest()
        {
            // TODO unit test for the property 'ContactStateChanged'
        }
        /// <summary>
        /// Test the property 'ListAdded'
        /// </summary>
        [Test]
        public void ListAddedTest()
        {
            // TODO unit test for the property 'ListAdded'
        }
        /// <summary>
        /// Test the property 'ListDeleted'
        /// </summary>
        [Test]
        public void ListDeletedTest()
        {
            // TODO unit test for the property 'ListDeleted'
        }
        /// <summary>
        /// Test the property 'ListStateChanged'
        /// </summary>
        [Test]
        public void ListStateChangedTest()
        {
            // TODO unit test for the property 'ListStateChanged'
        }
        /// <summary>
        /// Test the property 'ContactWipeEnd'
        /// </summary>
        [Test]
        public void ContactWipeEndTest()
        {
            // TODO unit test for the property 'ContactWipeEnd'
        }
        /// <summary>
        /// Test the property 'ContactImportEnd'
        /// </summary>
        [Test]
        public void ContactImportEndTest()
        {
            // TODO unit test for the property 'ContactImportEnd'
        }
        /// <summary>
        /// Test the property 'ContactCacheClear'
        /// </summary>
        [Test]
        public void ContactCacheClearTest()
        {
            // TODO unit test for the property 'ContactCacheClear'
        }
        /// <summary>
        /// Test the property 'ListCacheClear'
        /// </summary>
        [Test]
        public void ListCacheClearTest()
        {
            // TODO unit test for the property 'ListCacheClear'
        }
        /// <summary>
        /// Test the property 'CustomFieldsCacheClear'
        /// </summary>
        [Test]
        public void CustomFieldsCacheClearTest()
        {
            // TODO unit test for the property 'CustomFieldsCacheClear'
        }

    }

}
