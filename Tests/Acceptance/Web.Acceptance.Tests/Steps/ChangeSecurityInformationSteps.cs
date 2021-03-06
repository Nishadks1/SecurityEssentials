﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using SecurityEssentials.Acceptance.Tests.Web.Pages;
using TechTalk.SpecFlow;

namespace SecurityEssentials.Acceptance.Tests.Web.Extensions
{
	[Binding]
	public class ChangeSecurityInformationSteps
	{

		[Given(@"I enter the following change security information data:")]
		public void GivenIEnterTheFollowingChangeSecurityInformationData(Table table)
		{
			var changeSecurityInformationPage = ScenarioContext.Current.GetPage<ChangeSecurityInformationPage>();
			changeSecurityInformationPage.EnterDetails(table);
		}

		[When(@"I submit the change security information form")]
		public void WhenISubmitTheChangeSecurityInformationForm()
		{
			var changeSecurityInformationPage = ScenarioContext.Current.GetPage<ChangeSecurityInformationPage>();
			changeSecurityInformationPage.ClickSubmit();
		}

	}
}
