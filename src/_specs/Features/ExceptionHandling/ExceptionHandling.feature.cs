﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:1.9.0.77
//      SpecFlow Generator Version:1.9.0.0
//      Runtime Version:4.0.30319.17626
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace Patterns.Specifications.Features.ExceptionHandling
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "1.9.0.77")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("Exception Handling")]
    public partial class ExceptionHandlingFeature
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "ExceptionHandling.feature"
#line hidden
        
        [NUnit.Framework.TestFixtureSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Exception Handling", "As a developer, I want to be able to isolate the scope of error-prone code,\r\nand " +
                    "I want the ability to either rely on a basic error handling policy,\r\nor provide " +
                    "my own logic to respond to exceptions.", ProgrammingLanguage.CSharp, ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [NUnit.Framework.TestFixtureTearDownAttribute()]
        public virtual void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        [NUnit.Framework.SetUpAttribute()]
        public virtual void TestInitialize()
        {
        }
        
        [NUnit.Framework.TearDownAttribute()]
        public virtual void ScenarioTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public virtual void ScenarioSetup(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioStart(scenarioInfo);
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        public virtual void FeatureBackground()
        {
#line 6
#line 7
 testRunner.Given("I have prepared a test subject", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 8
 testRunner.And("I have subscribed to all observable feeds on the subject", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 9
 testRunner.And("I have set the default error handling behavior to record all errors for the test", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 10
 testRunner.And("I have created an observable feed for test errors", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("normal property read")]
        [NUnit.Framework.CategoryAttribute("trackReads")]
        [NUnit.Framework.CategoryAttribute("trackErrors")]
        [NUnit.Framework.CategoryAttribute("exceptionHandling")]
        public virtual void NormalPropertyRead()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("normal property read", new string[] {
                        "trackReads",
                        "trackErrors",
                        "exceptionHandling"});
#line 15
this.ScenarioSetup(scenarioInfo);
#line 6
this.FeatureBackground();
#line 16
 testRunner.When("I try to read a property value from the subject", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 17
 testRunner.Then("the value that I read should be the value I expected", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 18
 testRunner.And("the feed for property read requests should have returned 1 item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 19
 testRunner.And("the feed for property read responses should have returned 1 item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 20
 testRunner.And("the feed for errors should have returned 0 items", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("normal property write")]
        [NUnit.Framework.CategoryAttribute("trackWrites")]
        [NUnit.Framework.CategoryAttribute("trackErrors")]
        [NUnit.Framework.CategoryAttribute("exceptionHandling")]
        public virtual void NormalPropertyWrite()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("normal property write", new string[] {
                        "trackWrites",
                        "trackErrors",
                        "exceptionHandling"});
#line 25
this.ScenarioSetup(scenarioInfo);
#line 6
this.FeatureBackground();
#line 26
 testRunner.When("I try to write to a property value on the subject", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 27
 testRunner.And("I try to read a property value from the subject", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 28
 testRunner.Then("the value that I read should be the value I wrote", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 29
 testRunner.And("the feed for property write requests should have returned 1 item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 30
 testRunner.And("the feed for errors should have returned 0 items", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("normal method call")]
        [NUnit.Framework.CategoryAttribute("trackCalls")]
        [NUnit.Framework.CategoryAttribute("trackErrors")]
        [NUnit.Framework.CategoryAttribute("exceptionHandling")]
        public virtual void NormalMethodCall()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("normal method call", new string[] {
                        "trackCalls",
                        "trackErrors",
                        "exceptionHandling"});
#line 35
this.ScenarioSetup(scenarioInfo);
#line 6
this.FeatureBackground();
#line 36
 testRunner.When("I try to call a method on the subject", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 37
 testRunner.Then("the method call should complete with no errors", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 38
 testRunner.And("the feed for method call requests should have returned 1 item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 39
 testRunner.And("the feed for method call responses should have returned 1 item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 40
 testRunner.And("the feed for errors should have returned 0 items", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("angry property read")]
        [NUnit.Framework.CategoryAttribute("trackReads")]
        [NUnit.Framework.CategoryAttribute("trackErrors")]
        [NUnit.Framework.CategoryAttribute("exceptionHandling")]
        public virtual void AngryPropertyRead()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("angry property read", new string[] {
                        "trackReads",
                        "trackErrors",
                        "exceptionHandling"});
#line 45
this.ScenarioSetup(scenarioInfo);
#line 6
this.FeatureBackground();
#line 46
 testRunner.When("I try to read a value that throws an exception from the subject", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 47
 testRunner.Then("the value I read should be the default value for the return type", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 48
 testRunner.And("the feed for property read requests should have returned 1 item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 49
 testRunner.And("the feed for property read responses should have returned 0 items", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 50
 testRunner.And("the feed for errors should have returned 1 item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("angry property write")]
        [NUnit.Framework.CategoryAttribute("trackWrites")]
        [NUnit.Framework.CategoryAttribute("trackErrors")]
        [NUnit.Framework.CategoryAttribute("exceptionHandling")]
        public virtual void AngryPropertyWrite()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("angry property write", new string[] {
                        "trackWrites",
                        "trackErrors",
                        "exceptionHandling"});
#line 55
this.ScenarioSetup(scenarioInfo);
#line 6
this.FeatureBackground();
#line 56
 testRunner.When("I try to write to a property value that throws an exception on the subject", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 57
 testRunner.And("I try to read a property value from the subject", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 58
 testRunner.Then("the value that I read should be the value I expected", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 59
 testRunner.And("the feed for property write requests should have returned 1 item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 60
 testRunner.And("the feed for errors should have returned 1 item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("angry method call")]
        [NUnit.Framework.CategoryAttribute("trackCalls")]
        [NUnit.Framework.CategoryAttribute("trackErrors")]
        [NUnit.Framework.CategoryAttribute("exceptionHandling")]
        public virtual void AngryMethodCall()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("angry method call", new string[] {
                        "trackCalls",
                        "trackErrors",
                        "exceptionHandling"});
#line 65
this.ScenarioSetup(scenarioInfo);
#line 6
this.FeatureBackground();
#line 66
 testRunner.When("I try to call a method that throws an exception on the subject", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 67
 testRunner.Then("the method call should abort", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 68
 testRunner.And("the feed for method call requests should have returned 1 item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 69
 testRunner.And("the feed for method call responses should have returned 0 items", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 70
 testRunner.And("the feed for errors should have returned 1 item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("angry property read with error handling")]
        [NUnit.Framework.CategoryAttribute("trackReads")]
        [NUnit.Framework.CategoryAttribute("trackErrors")]
        [NUnit.Framework.CategoryAttribute("exceptionHandling")]
        public virtual void AngryPropertyReadWithErrorHandling()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("angry property read with error handling", new string[] {
                        "trackReads",
                        "trackErrors",
                        "exceptionHandling"});
#line 75
this.ScenarioSetup(scenarioInfo);
#line 6
this.FeatureBackground();
#line 76
 testRunner.Given("I have a custom error handler that does not write to the error feed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 77
 testRunner.When("I try to read a value that throws an exception from the subject", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 78
 testRunner.Then("the value I read should be the default value for the return type", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 79
 testRunner.And("the feed for property read requests should have returned 1 item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 80
 testRunner.And("the feed for property read responses should have returned 0 items", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 81
 testRunner.And("the feed for errors should have returned 0 items", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("angry property write with error handling")]
        [NUnit.Framework.CategoryAttribute("trackWrites")]
        [NUnit.Framework.CategoryAttribute("trackErrors")]
        [NUnit.Framework.CategoryAttribute("exceptionHandling")]
        public virtual void AngryPropertyWriteWithErrorHandling()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("angry property write with error handling", new string[] {
                        "trackWrites",
                        "trackErrors",
                        "exceptionHandling"});
#line 86
this.ScenarioSetup(scenarioInfo);
#line 6
this.FeatureBackground();
#line 87
 testRunner.Given("I have a custom error handler that does not write to the error feed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 88
 testRunner.When("I try to write to a property value that throws an exception on the subject", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 89
 testRunner.And("I try to read a property value from the subject", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 90
 testRunner.Then("the value that I read should be the value I expected", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 91
 testRunner.And("the feed for property write requests should have returned 1 item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 92
 testRunner.And("the feed for errors should have returned 0 items", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("angry method call with error handling")]
        [NUnit.Framework.CategoryAttribute("trackCalls")]
        [NUnit.Framework.CategoryAttribute("trackErrors")]
        [NUnit.Framework.CategoryAttribute("exceptionHandling")]
        public virtual void AngryMethodCallWithErrorHandling()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("angry method call with error handling", new string[] {
                        "trackCalls",
                        "trackErrors",
                        "exceptionHandling"});
#line 97
this.ScenarioSetup(scenarioInfo);
#line 6
this.FeatureBackground();
#line 98
 testRunner.Given("I have a custom error handler that does not write to the error feed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 99
 testRunner.When("I try to call a method that throws an exception on the subject", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 100
 testRunner.Then("the method call should abort", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 101
 testRunner.And("the feed for method call requests should have returned 1 item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 102
 testRunner.And("the feed for method call responses should have returned 0 items", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 103
 testRunner.And("the feed for errors should have returned 0 items", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion