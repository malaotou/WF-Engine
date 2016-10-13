namespace BOC.GSP.V2.WF.Engine {
    
    #line 28 "E:\WorkFolder\中国银行CRM\04 Code\BOC.GSP.V2.V3\BOCGSP2Project\BOC.GSP.V2\WF\Engine\BOC.GSP.V2.WF.Engine\WFInstance.xaml"
    using System;
    
    #line default
    #line hidden
    
    #line 1 "E:\WorkFolder\中国银行CRM\04 Code\BOC.GSP.V2.V3\BOCGSP2Project\BOC.GSP.V2\WF\Engine\BOC.GSP.V2.WF.Engine\WFInstance.xaml"
    using System.Collections;
    
    #line default
    #line hidden
    
    #line 29 "E:\WorkFolder\中国银行CRM\04 Code\BOC.GSP.V2.V3\BOCGSP2Project\BOC.GSP.V2\WF\Engine\BOC.GSP.V2.WF.Engine\WFInstance.xaml"
    using System.Collections.Generic;
    
    #line default
    #line hidden
    
    #line 1 "E:\WorkFolder\中国银行CRM\04 Code\BOC.GSP.V2.V3\BOCGSP2Project\BOC.GSP.V2\WF\Engine\BOC.GSP.V2.WF.Engine\WFInstance.xaml"
    using System.Activities;
    
    #line default
    #line hidden
    
    #line 1 "E:\WorkFolder\中国银行CRM\04 Code\BOC.GSP.V2.V3\BOCGSP2Project\BOC.GSP.V2\WF\Engine\BOC.GSP.V2.WF.Engine\WFInstance.xaml"
    using System.Activities.Expressions;
    
    #line default
    #line hidden
    
    #line 1 "E:\WorkFolder\中国银行CRM\04 Code\BOC.GSP.V2.V3\BOCGSP2Project\BOC.GSP.V2\WF\Engine\BOC.GSP.V2.WF.Engine\WFInstance.xaml"
    using System.Activities.Statements;
    
    #line default
    #line hidden
    
    #line 30 "E:\WorkFolder\中国银行CRM\04 Code\BOC.GSP.V2.V3\BOCGSP2Project\BOC.GSP.V2\WF\Engine\BOC.GSP.V2.WF.Engine\WFInstance.xaml"
    using System.Data;
    
    #line default
    #line hidden
    
    #line 31 "E:\WorkFolder\中国银行CRM\04 Code\BOC.GSP.V2.V3\BOCGSP2Project\BOC.GSP.V2\WF\Engine\BOC.GSP.V2.WF.Engine\WFInstance.xaml"
    using System.Linq;
    
    #line default
    #line hidden
    
    #line 32 "E:\WorkFolder\中国银行CRM\04 Code\BOC.GSP.V2.V3\BOCGSP2Project\BOC.GSP.V2\WF\Engine\BOC.GSP.V2.WF.Engine\WFInstance.xaml"
    using System.Text;
    
    #line default
    #line hidden
    
    #line 33 "E:\WorkFolder\中国银行CRM\04 Code\BOC.GSP.V2.V3\BOCGSP2Project\BOC.GSP.V2\WF\Engine\BOC.GSP.V2.WF.Engine\WFInstance.xaml"
    using BOC.GSP.V2.WF.Common.Variable;
    
    #line default
    #line hidden
    
    #line 1 "E:\WorkFolder\中国银行CRM\04 Code\BOC.GSP.V2.V3\BOCGSP2Project\BOC.GSP.V2\WF\Engine\BOC.GSP.V2.WF.Engine\WFInstance.xaml"
    using System.Activities.XamlIntegration;
    
    #line default
    #line hidden
    
    
    public partial class WFInstance : System.Activities.XamlIntegration.ICompiledExpressionRoot {
        
        private System.Activities.Activity rootActivity;
        
        private object dataContextActivities;
        
        private bool forImplementation = true;
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public string GetLanguage() {
            return "C#";
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public object InvokeExpression(int expressionId, System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext) {
            if ((this.rootActivity == null)) {
                this.rootActivity = this;
            }
            if ((this.dataContextActivities == null)) {
                this.dataContextActivities = WFInstance_TypedDataContext0_ForReadOnly.GetDataContextActivitiesHelper(this.rootActivity, this.forImplementation);
            }
            if ((expressionId == 0)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = WFInstance_TypedDataContext0_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 7);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new WFInstance_TypedDataContext0_ForReadOnly(locations, activityContext, true);
                }
                WFInstance_TypedDataContext0_ForReadOnly valDataContext0 = ((WFInstance_TypedDataContext0_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext0.ValueType___Expr0Get();
            }
            if ((expressionId == 1)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = WFInstance_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 7);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new WFInstance_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                WFInstance_TypedDataContext2_ForReadOnly valDataContext1 = ((WFInstance_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[1]));
                return valDataContext1.ValueType___Expr1Get();
            }
            if ((expressionId == 2)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = WFInstance_TypedDataContext3_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 7);
                if ((cachedCompiledDataContext[2] == null)) {
                    cachedCompiledDataContext[2] = new WFInstance_TypedDataContext3_ForReadOnly(locations, activityContext, true);
                }
                WFInstance_TypedDataContext3_ForReadOnly valDataContext2 = ((WFInstance_TypedDataContext3_ForReadOnly)(cachedCompiledDataContext[2]));
                return valDataContext2.ValueType___Expr2Get();
            }
            if ((expressionId == 3)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = WFInstance_TypedDataContext3.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 7);
                if ((cachedCompiledDataContext[3] == null)) {
                    cachedCompiledDataContext[3] = new WFInstance_TypedDataContext3(locations, activityContext, true);
                }
                WFInstance_TypedDataContext3 refDataContext3 = ((WFInstance_TypedDataContext3)(cachedCompiledDataContext[3]));
                return refDataContext3.GetLocation<BOC.GSP.V2.WF.Common.Variable.ActivityPara>(refDataContext3.ValueType___Expr3Get, refDataContext3.ValueType___Expr3Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 4)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = WFInstance_TypedDataContext3_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 7);
                if ((cachedCompiledDataContext[2] == null)) {
                    cachedCompiledDataContext[2] = new WFInstance_TypedDataContext3_ForReadOnly(locations, activityContext, true);
                }
                WFInstance_TypedDataContext3_ForReadOnly valDataContext4 = ((WFInstance_TypedDataContext3_ForReadOnly)(cachedCompiledDataContext[2]));
                return valDataContext4.ValueType___Expr4Get();
            }
            if ((expressionId == 5)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = WFInstance_TypedDataContext3_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 7);
                if ((cachedCompiledDataContext[2] == null)) {
                    cachedCompiledDataContext[2] = new WFInstance_TypedDataContext3_ForReadOnly(locations, activityContext, true);
                }
                WFInstance_TypedDataContext3_ForReadOnly valDataContext5 = ((WFInstance_TypedDataContext3_ForReadOnly)(cachedCompiledDataContext[2]));
                return valDataContext5.ValueType___Expr5Get();
            }
            if ((expressionId == 6)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = WFInstance_TypedDataContext4_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 7);
                if ((cachedCompiledDataContext[4] == null)) {
                    cachedCompiledDataContext[4] = new WFInstance_TypedDataContext4_ForReadOnly(locations, activityContext, true);
                }
                WFInstance_TypedDataContext4_ForReadOnly valDataContext6 = ((WFInstance_TypedDataContext4_ForReadOnly)(cachedCompiledDataContext[4]));
                return valDataContext6.ValueType___Expr6Get();
            }
            if ((expressionId == 7)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = WFInstance_TypedDataContext4_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 7);
                if ((cachedCompiledDataContext[4] == null)) {
                    cachedCompiledDataContext[4] = new WFInstance_TypedDataContext4_ForReadOnly(locations, activityContext, true);
                }
                WFInstance_TypedDataContext4_ForReadOnly valDataContext7 = ((WFInstance_TypedDataContext4_ForReadOnly)(cachedCompiledDataContext[4]));
                return valDataContext7.ValueType___Expr7Get();
            }
            if ((expressionId == 8)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = WFInstance_TypedDataContext6_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 7);
                if ((cachedCompiledDataContext[5] == null)) {
                    cachedCompiledDataContext[5] = new WFInstance_TypedDataContext6_ForReadOnly(locations, activityContext, true);
                }
                WFInstance_TypedDataContext6_ForReadOnly valDataContext8 = ((WFInstance_TypedDataContext6_ForReadOnly)(cachedCompiledDataContext[5]));
                return valDataContext8.ValueType___Expr8Get();
            }
            if ((expressionId == 9)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = WFInstance_TypedDataContext6_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 7);
                if ((cachedCompiledDataContext[5] == null)) {
                    cachedCompiledDataContext[5] = new WFInstance_TypedDataContext6_ForReadOnly(locations, activityContext, true);
                }
                WFInstance_TypedDataContext6_ForReadOnly valDataContext9 = ((WFInstance_TypedDataContext6_ForReadOnly)(cachedCompiledDataContext[5]));
                return valDataContext9.ValueType___Expr9Get();
            }
            if ((expressionId == 10)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = WFInstance_TypedDataContext6.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 7);
                if ((cachedCompiledDataContext[6] == null)) {
                    cachedCompiledDataContext[6] = new WFInstance_TypedDataContext6(locations, activityContext, true);
                }
                WFInstance_TypedDataContext6 refDataContext10 = ((WFInstance_TypedDataContext6)(cachedCompiledDataContext[6]));
                return refDataContext10.GetLocation<System.Guid>(refDataContext10.ValueType___Expr10Get, refDataContext10.ValueType___Expr10Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 11)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = WFInstance_TypedDataContext6_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 7);
                if ((cachedCompiledDataContext[5] == null)) {
                    cachedCompiledDataContext[5] = new WFInstance_TypedDataContext6_ForReadOnly(locations, activityContext, true);
                }
                WFInstance_TypedDataContext6_ForReadOnly valDataContext11 = ((WFInstance_TypedDataContext6_ForReadOnly)(cachedCompiledDataContext[5]));
                return valDataContext11.ValueType___Expr11Get();
            }
            if ((expressionId == 12)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = WFInstance_TypedDataContext6.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 7);
                if ((cachedCompiledDataContext[6] == null)) {
                    cachedCompiledDataContext[6] = new WFInstance_TypedDataContext6(locations, activityContext, true);
                }
                WFInstance_TypedDataContext6 refDataContext12 = ((WFInstance_TypedDataContext6)(cachedCompiledDataContext[6]));
                return refDataContext12.GetLocation<System.Guid>(refDataContext12.ValueType___Expr12Get, refDataContext12.ValueType___Expr12Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 13)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = WFInstance_TypedDataContext6_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 7);
                if ((cachedCompiledDataContext[5] == null)) {
                    cachedCompiledDataContext[5] = new WFInstance_TypedDataContext6_ForReadOnly(locations, activityContext, true);
                }
                WFInstance_TypedDataContext6_ForReadOnly valDataContext13 = ((WFInstance_TypedDataContext6_ForReadOnly)(cachedCompiledDataContext[5]));
                return valDataContext13.ValueType___Expr13Get();
            }
            if ((expressionId == 14)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = WFInstance_TypedDataContext6.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 7);
                if ((cachedCompiledDataContext[6] == null)) {
                    cachedCompiledDataContext[6] = new WFInstance_TypedDataContext6(locations, activityContext, true);
                }
                WFInstance_TypedDataContext6 refDataContext14 = ((WFInstance_TypedDataContext6)(cachedCompiledDataContext[6]));
                return refDataContext14.GetLocation<int>(refDataContext14.ValueType___Expr14Get, refDataContext14.ValueType___Expr14Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 15)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = WFInstance_TypedDataContext6_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 7);
                if ((cachedCompiledDataContext[5] == null)) {
                    cachedCompiledDataContext[5] = new WFInstance_TypedDataContext6_ForReadOnly(locations, activityContext, true);
                }
                WFInstance_TypedDataContext6_ForReadOnly valDataContext15 = ((WFInstance_TypedDataContext6_ForReadOnly)(cachedCompiledDataContext[5]));
                return valDataContext15.ValueType___Expr15Get();
            }
            if ((expressionId == 16)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = WFInstance_TypedDataContext6.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 7);
                if ((cachedCompiledDataContext[6] == null)) {
                    cachedCompiledDataContext[6] = new WFInstance_TypedDataContext6(locations, activityContext, true);
                }
                WFInstance_TypedDataContext6 refDataContext16 = ((WFInstance_TypedDataContext6)(cachedCompiledDataContext[6]));
                return refDataContext16.GetLocation<int>(refDataContext16.ValueType___Expr16Get, refDataContext16.ValueType___Expr16Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 17)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = WFInstance_TypedDataContext6.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 7);
                if ((cachedCompiledDataContext[6] == null)) {
                    cachedCompiledDataContext[6] = new WFInstance_TypedDataContext6(locations, activityContext, true);
                }
                WFInstance_TypedDataContext6 refDataContext17 = ((WFInstance_TypedDataContext6)(cachedCompiledDataContext[6]));
                return refDataContext17.GetLocation<string>(refDataContext17.ValueType___Expr17Get, refDataContext17.ValueType___Expr17Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 18)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = WFInstance_TypedDataContext6_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 7);
                if ((cachedCompiledDataContext[5] == null)) {
                    cachedCompiledDataContext[5] = new WFInstance_TypedDataContext6_ForReadOnly(locations, activityContext, true);
                }
                WFInstance_TypedDataContext6_ForReadOnly valDataContext18 = ((WFInstance_TypedDataContext6_ForReadOnly)(cachedCompiledDataContext[5]));
                return valDataContext18.ValueType___Expr18Get();
            }
            if ((expressionId == 19)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = WFInstance_TypedDataContext6.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 7);
                if ((cachedCompiledDataContext[6] == null)) {
                    cachedCompiledDataContext[6] = new WFInstance_TypedDataContext6(locations, activityContext, true);
                }
                WFInstance_TypedDataContext6 refDataContext19 = ((WFInstance_TypedDataContext6)(cachedCompiledDataContext[6]));
                return refDataContext19.GetLocation<System.Collections.Generic.List<BOC.GSP.V2.WF.Common.Variable.NextActivity>>(refDataContext19.ValueType___Expr19Get, refDataContext19.ValueType___Expr19Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 20)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = WFInstance_TypedDataContext6_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 7);
                if ((cachedCompiledDataContext[5] == null)) {
                    cachedCompiledDataContext[5] = new WFInstance_TypedDataContext6_ForReadOnly(locations, activityContext, true);
                }
                WFInstance_TypedDataContext6_ForReadOnly valDataContext20 = ((WFInstance_TypedDataContext6_ForReadOnly)(cachedCompiledDataContext[5]));
                return valDataContext20.ValueType___Expr20Get();
            }
            if ((expressionId == 21)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = WFInstance_TypedDataContext6.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 7);
                if ((cachedCompiledDataContext[6] == null)) {
                    cachedCompiledDataContext[6] = new WFInstance_TypedDataContext6(locations, activityContext, true);
                }
                WFInstance_TypedDataContext6 refDataContext21 = ((WFInstance_TypedDataContext6)(cachedCompiledDataContext[6]));
                return refDataContext21.GetLocation<int>(refDataContext21.ValueType___Expr21Get, refDataContext21.ValueType___Expr21Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 22)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = WFInstance_TypedDataContext6.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 7);
                if ((cachedCompiledDataContext[6] == null)) {
                    cachedCompiledDataContext[6] = new WFInstance_TypedDataContext6(locations, activityContext, true);
                }
                WFInstance_TypedDataContext6 refDataContext22 = ((WFInstance_TypedDataContext6)(cachedCompiledDataContext[6]));
                return refDataContext22.GetLocation<BOC.GSP.V2.WF.Common.Variable.ActivityPara>(refDataContext22.ValueType___Expr22Get, refDataContext22.ValueType___Expr22Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 23)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = WFInstance_TypedDataContext4_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 7);
                if ((cachedCompiledDataContext[4] == null)) {
                    cachedCompiledDataContext[4] = new WFInstance_TypedDataContext4_ForReadOnly(locations, activityContext, true);
                }
                WFInstance_TypedDataContext4_ForReadOnly valDataContext23 = ((WFInstance_TypedDataContext4_ForReadOnly)(cachedCompiledDataContext[4]));
                return valDataContext23.ValueType___Expr23Get();
            }
            return null;
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public object InvokeExpression(int expressionId, System.Collections.Generic.IList<System.Activities.Location> locations) {
            if ((this.rootActivity == null)) {
                this.rootActivity = this;
            }
            if ((expressionId == 0)) {
                WFInstance_TypedDataContext0_ForReadOnly valDataContext0 = new WFInstance_TypedDataContext0_ForReadOnly(locations, true);
                return valDataContext0.ValueType___Expr0Get();
            }
            if ((expressionId == 1)) {
                WFInstance_TypedDataContext2_ForReadOnly valDataContext1 = new WFInstance_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext1.ValueType___Expr1Get();
            }
            if ((expressionId == 2)) {
                WFInstance_TypedDataContext3_ForReadOnly valDataContext2 = new WFInstance_TypedDataContext3_ForReadOnly(locations, true);
                return valDataContext2.ValueType___Expr2Get();
            }
            if ((expressionId == 3)) {
                WFInstance_TypedDataContext3 refDataContext3 = new WFInstance_TypedDataContext3(locations, true);
                return refDataContext3.GetLocation<BOC.GSP.V2.WF.Common.Variable.ActivityPara>(refDataContext3.ValueType___Expr3Get, refDataContext3.ValueType___Expr3Set);
            }
            if ((expressionId == 4)) {
                WFInstance_TypedDataContext3_ForReadOnly valDataContext4 = new WFInstance_TypedDataContext3_ForReadOnly(locations, true);
                return valDataContext4.ValueType___Expr4Get();
            }
            if ((expressionId == 5)) {
                WFInstance_TypedDataContext3_ForReadOnly valDataContext5 = new WFInstance_TypedDataContext3_ForReadOnly(locations, true);
                return valDataContext5.ValueType___Expr5Get();
            }
            if ((expressionId == 6)) {
                WFInstance_TypedDataContext4_ForReadOnly valDataContext6 = new WFInstance_TypedDataContext4_ForReadOnly(locations, true);
                return valDataContext6.ValueType___Expr6Get();
            }
            if ((expressionId == 7)) {
                WFInstance_TypedDataContext4_ForReadOnly valDataContext7 = new WFInstance_TypedDataContext4_ForReadOnly(locations, true);
                return valDataContext7.ValueType___Expr7Get();
            }
            if ((expressionId == 8)) {
                WFInstance_TypedDataContext6_ForReadOnly valDataContext8 = new WFInstance_TypedDataContext6_ForReadOnly(locations, true);
                return valDataContext8.ValueType___Expr8Get();
            }
            if ((expressionId == 9)) {
                WFInstance_TypedDataContext6_ForReadOnly valDataContext9 = new WFInstance_TypedDataContext6_ForReadOnly(locations, true);
                return valDataContext9.ValueType___Expr9Get();
            }
            if ((expressionId == 10)) {
                WFInstance_TypedDataContext6 refDataContext10 = new WFInstance_TypedDataContext6(locations, true);
                return refDataContext10.GetLocation<System.Guid>(refDataContext10.ValueType___Expr10Get, refDataContext10.ValueType___Expr10Set);
            }
            if ((expressionId == 11)) {
                WFInstance_TypedDataContext6_ForReadOnly valDataContext11 = new WFInstance_TypedDataContext6_ForReadOnly(locations, true);
                return valDataContext11.ValueType___Expr11Get();
            }
            if ((expressionId == 12)) {
                WFInstance_TypedDataContext6 refDataContext12 = new WFInstance_TypedDataContext6(locations, true);
                return refDataContext12.GetLocation<System.Guid>(refDataContext12.ValueType___Expr12Get, refDataContext12.ValueType___Expr12Set);
            }
            if ((expressionId == 13)) {
                WFInstance_TypedDataContext6_ForReadOnly valDataContext13 = new WFInstance_TypedDataContext6_ForReadOnly(locations, true);
                return valDataContext13.ValueType___Expr13Get();
            }
            if ((expressionId == 14)) {
                WFInstance_TypedDataContext6 refDataContext14 = new WFInstance_TypedDataContext6(locations, true);
                return refDataContext14.GetLocation<int>(refDataContext14.ValueType___Expr14Get, refDataContext14.ValueType___Expr14Set);
            }
            if ((expressionId == 15)) {
                WFInstance_TypedDataContext6_ForReadOnly valDataContext15 = new WFInstance_TypedDataContext6_ForReadOnly(locations, true);
                return valDataContext15.ValueType___Expr15Get();
            }
            if ((expressionId == 16)) {
                WFInstance_TypedDataContext6 refDataContext16 = new WFInstance_TypedDataContext6(locations, true);
                return refDataContext16.GetLocation<int>(refDataContext16.ValueType___Expr16Get, refDataContext16.ValueType___Expr16Set);
            }
            if ((expressionId == 17)) {
                WFInstance_TypedDataContext6 refDataContext17 = new WFInstance_TypedDataContext6(locations, true);
                return refDataContext17.GetLocation<string>(refDataContext17.ValueType___Expr17Get, refDataContext17.ValueType___Expr17Set);
            }
            if ((expressionId == 18)) {
                WFInstance_TypedDataContext6_ForReadOnly valDataContext18 = new WFInstance_TypedDataContext6_ForReadOnly(locations, true);
                return valDataContext18.ValueType___Expr18Get();
            }
            if ((expressionId == 19)) {
                WFInstance_TypedDataContext6 refDataContext19 = new WFInstance_TypedDataContext6(locations, true);
                return refDataContext19.GetLocation<System.Collections.Generic.List<BOC.GSP.V2.WF.Common.Variable.NextActivity>>(refDataContext19.ValueType___Expr19Get, refDataContext19.ValueType___Expr19Set);
            }
            if ((expressionId == 20)) {
                WFInstance_TypedDataContext6_ForReadOnly valDataContext20 = new WFInstance_TypedDataContext6_ForReadOnly(locations, true);
                return valDataContext20.ValueType___Expr20Get();
            }
            if ((expressionId == 21)) {
                WFInstance_TypedDataContext6 refDataContext21 = new WFInstance_TypedDataContext6(locations, true);
                return refDataContext21.GetLocation<int>(refDataContext21.ValueType___Expr21Get, refDataContext21.ValueType___Expr21Set);
            }
            if ((expressionId == 22)) {
                WFInstance_TypedDataContext6 refDataContext22 = new WFInstance_TypedDataContext6(locations, true);
                return refDataContext22.GetLocation<BOC.GSP.V2.WF.Common.Variable.ActivityPara>(refDataContext22.ValueType___Expr22Get, refDataContext22.ValueType___Expr22Set);
            }
            if ((expressionId == 23)) {
                WFInstance_TypedDataContext4_ForReadOnly valDataContext23 = new WFInstance_TypedDataContext4_ForReadOnly(locations, true);
                return valDataContext23.ValueType___Expr23Get();
            }
            return null;
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public bool CanExecuteExpression(string expressionText, bool isReference, System.Collections.Generic.IList<System.Activities.LocationReference> locations, out int expressionId) {
            if (((isReference == false) 
                        && ((expressionText == "new ActivityPara()") 
                        && (WFInstance_TypedDataContext0_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 0;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "para.clone()") 
                        && (WFInstance_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 1;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "para.ActType==1") 
                        && (WFInstance_TypedDataContext3_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 2;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "para") 
                        && (WFInstance_TypedDataContext3.Validate(locations, true, 0) == true)))) {
                expressionId = 3;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "para") 
                        && (WFInstance_TypedDataContext3_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 4;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "para") 
                        && (WFInstance_TypedDataContext3_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 5;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "para.ActType!=2") 
                        && (WFInstance_TypedDataContext4_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 6;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "para.NextAct") 
                        && (WFInstance_TypedDataContext4_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 7;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "para.clone()") 
                        && (WFInstance_TypedDataContext6_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 8;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "para.ProcessID") 
                        && (WFInstance_TypedDataContext6_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 9;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "nextPara.ProcessID") 
                        && (WFInstance_TypedDataContext6.Validate(locations, true, 0) == true)))) {
                expressionId = 10;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "para.ProcessInstanceId") 
                        && (WFInstance_TypedDataContext6_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 11;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "nextPara.ProcessInstanceId") 
                        && (WFInstance_TypedDataContext6.Validate(locations, true, 0) == true)))) {
                expressionId = 12;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "item.NextActId") 
                        && (WFInstance_TypedDataContext6_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 13;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "nextPara.ActId") 
                        && (WFInstance_TypedDataContext6.Validate(locations, true, 0) == true)))) {
                expressionId = 14;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "item.NextActExecType") 
                        && (WFInstance_TypedDataContext6_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 15;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "nextPara.ActType") 
                        && (WFInstance_TypedDataContext6.Validate(locations, true, 0) == true)))) {
                expressionId = 16;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "nextPara.ADUser") 
                        && (WFInstance_TypedDataContext6.Validate(locations, true, 0) == true)))) {
                expressionId = 17;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "null") 
                        && (WFInstance_TypedDataContext6_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 18;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "nextPara.NextAct") 
                        && (WFInstance_TypedDataContext6.Validate(locations, true, 0) == true)))) {
                expressionId = 19;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "item.ApproveType") 
                        && (WFInstance_TypedDataContext6_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 20;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "nextPara.ExecType") 
                        && (WFInstance_TypedDataContext6.Validate(locations, true, 0) == true)))) {
                expressionId = 21;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "nextPara") 
                        && (WFInstance_TypedDataContext6.Validate(locations, true, 0) == true)))) {
                expressionId = 22;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "para") 
                        && (WFInstance_TypedDataContext4_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 23;
                return true;
            }
            expressionId = -1;
            return false;
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public System.Collections.Generic.IList<string> GetRequiredLocations(int expressionId) {
            return null;
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public System.Linq.Expressions.Expression GetExpressionTreeForExpression(int expressionId, System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) {
            if ((expressionId == 0)) {
                return new WFInstance_TypedDataContext0_ForReadOnly(locationReferences).@__Expr0GetTree();
            }
            if ((expressionId == 1)) {
                return new WFInstance_TypedDataContext2_ForReadOnly(locationReferences).@__Expr1GetTree();
            }
            if ((expressionId == 2)) {
                return new WFInstance_TypedDataContext3_ForReadOnly(locationReferences).@__Expr2GetTree();
            }
            if ((expressionId == 3)) {
                return new WFInstance_TypedDataContext3(locationReferences).@__Expr3GetTree();
            }
            if ((expressionId == 4)) {
                return new WFInstance_TypedDataContext3_ForReadOnly(locationReferences).@__Expr4GetTree();
            }
            if ((expressionId == 5)) {
                return new WFInstance_TypedDataContext3_ForReadOnly(locationReferences).@__Expr5GetTree();
            }
            if ((expressionId == 6)) {
                return new WFInstance_TypedDataContext4_ForReadOnly(locationReferences).@__Expr6GetTree();
            }
            if ((expressionId == 7)) {
                return new WFInstance_TypedDataContext4_ForReadOnly(locationReferences).@__Expr7GetTree();
            }
            if ((expressionId == 8)) {
                return new WFInstance_TypedDataContext6_ForReadOnly(locationReferences).@__Expr8GetTree();
            }
            if ((expressionId == 9)) {
                return new WFInstance_TypedDataContext6_ForReadOnly(locationReferences).@__Expr9GetTree();
            }
            if ((expressionId == 10)) {
                return new WFInstance_TypedDataContext6(locationReferences).@__Expr10GetTree();
            }
            if ((expressionId == 11)) {
                return new WFInstance_TypedDataContext6_ForReadOnly(locationReferences).@__Expr11GetTree();
            }
            if ((expressionId == 12)) {
                return new WFInstance_TypedDataContext6(locationReferences).@__Expr12GetTree();
            }
            if ((expressionId == 13)) {
                return new WFInstance_TypedDataContext6_ForReadOnly(locationReferences).@__Expr13GetTree();
            }
            if ((expressionId == 14)) {
                return new WFInstance_TypedDataContext6(locationReferences).@__Expr14GetTree();
            }
            if ((expressionId == 15)) {
                return new WFInstance_TypedDataContext6_ForReadOnly(locationReferences).@__Expr15GetTree();
            }
            if ((expressionId == 16)) {
                return new WFInstance_TypedDataContext6(locationReferences).@__Expr16GetTree();
            }
            if ((expressionId == 17)) {
                return new WFInstance_TypedDataContext6(locationReferences).@__Expr17GetTree();
            }
            if ((expressionId == 18)) {
                return new WFInstance_TypedDataContext6_ForReadOnly(locationReferences).@__Expr18GetTree();
            }
            if ((expressionId == 19)) {
                return new WFInstance_TypedDataContext6(locationReferences).@__Expr19GetTree();
            }
            if ((expressionId == 20)) {
                return new WFInstance_TypedDataContext6_ForReadOnly(locationReferences).@__Expr20GetTree();
            }
            if ((expressionId == 21)) {
                return new WFInstance_TypedDataContext6(locationReferences).@__Expr21GetTree();
            }
            if ((expressionId == 22)) {
                return new WFInstance_TypedDataContext6(locationReferences).@__Expr22GetTree();
            }
            if ((expressionId == 23)) {
                return new WFInstance_TypedDataContext4_ForReadOnly(locationReferences).@__Expr23GetTree();
            }
            return null;
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class WFInstance_TypedDataContext0 : System.Activities.XamlIntegration.CompiledDataContext {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            public WFInstance_TypedDataContext0(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public WFInstance_TypedDataContext0(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public WFInstance_TypedDataContext0(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            internal static object GetDataContextActivitiesHelper(System.Activities.Activity compiledRoot, bool forImplementation) {
                return System.Activities.XamlIntegration.CompiledDataContext.GetDataContextActivities(compiledRoot, forImplementation);
            }
            
            internal static System.Activities.XamlIntegration.CompiledDataContext[] GetCompiledDataContextCacheHelper(object dataContextActivities, System.Activities.ActivityContext activityContext, System.Activities.Activity compiledRoot, bool forImplementation, int compiledDataContextCount) {
                return System.Activities.XamlIntegration.CompiledDataContext.GetCompiledDataContextCache(dataContextActivities, activityContext, compiledRoot, forImplementation, compiledDataContextCount);
            }
            
            public virtual void SetLocationsOffset(int locationsOffsetValue) {
                locationsOffset = locationsOffsetValue;
            }
            
            public static bool Validate(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences, bool validateLocationCount, int offset) {
                if (((validateLocationCount == true) 
                            && (locationReferences.Count < 0))) {
                    return false;
                }
                expectedLocationsCount = 0;
                return true;
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class WFInstance_TypedDataContext0_ForReadOnly : System.Activities.XamlIntegration.CompiledDataContext {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            public WFInstance_TypedDataContext0_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public WFInstance_TypedDataContext0_ForReadOnly(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public WFInstance_TypedDataContext0_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            internal static object GetDataContextActivitiesHelper(System.Activities.Activity compiledRoot, bool forImplementation) {
                return System.Activities.XamlIntegration.CompiledDataContext.GetDataContextActivities(compiledRoot, forImplementation);
            }
            
            internal static System.Activities.XamlIntegration.CompiledDataContext[] GetCompiledDataContextCacheHelper(object dataContextActivities, System.Activities.ActivityContext activityContext, System.Activities.Activity compiledRoot, bool forImplementation, int compiledDataContextCount) {
                return System.Activities.XamlIntegration.CompiledDataContext.GetCompiledDataContextCache(dataContextActivities, activityContext, compiledRoot, forImplementation, compiledDataContextCount);
            }
            
            public virtual void SetLocationsOffset(int locationsOffsetValue) {
                locationsOffset = locationsOffsetValue;
            }
            
            internal System.Linq.Expressions.Expression @__Expr0GetTree() {
                
                #line 20 "E:\WORKFOLDER\中国银行CRM\04 CODE\BOC.GSP.V2.V3\BOCGSP2PROJECT\BOC.GSP.V2\WF\ENGINE\BOC.GSP.V2.WF.ENGINE\WFINSTANCE.XAML"
                System.Linq.Expressions.Expression<System.Func<BOC.GSP.V2.WF.Common.Variable.ActivityPara>> expression = () => 
      new ActivityPara();
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public BOC.GSP.V2.WF.Common.Variable.ActivityPara @__Expr0Get() {
                
                #line 20 "E:\WORKFOLDER\中国银行CRM\04 CODE\BOC.GSP.V2.V3\BOCGSP2PROJECT\BOC.GSP.V2\WF\ENGINE\BOC.GSP.V2.WF.ENGINE\WFINSTANCE.XAML"
                return 
      new ActivityPara();
                
                #line default
                #line hidden
            }
            
            public BOC.GSP.V2.WF.Common.Variable.ActivityPara ValueType___Expr0Get() {
                this.GetValueTypeValues();
                return this.@__Expr0Get();
            }
            
            public static bool Validate(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences, bool validateLocationCount, int offset) {
                if (((validateLocationCount == true) 
                            && (locationReferences.Count < 0))) {
                    return false;
                }
                expectedLocationsCount = 0;
                return true;
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class WFInstance_TypedDataContext1 : WFInstance_TypedDataContext0 {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            public WFInstance_TypedDataContext1(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public WFInstance_TypedDataContext1(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public WFInstance_TypedDataContext1(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            protected BOC.GSP.V2.WF.Common.Variable.ActivityPara para {
                get {
                    return ((BOC.GSP.V2.WF.Common.Variable.ActivityPara)(this.GetVariableValue((0 + locationsOffset))));
                }
                set {
                    this.SetVariableValue((0 + locationsOffset), value);
                }
            }
            
            internal new static System.Activities.XamlIntegration.CompiledDataContext[] GetCompiledDataContextCacheHelper(object dataContextActivities, System.Activities.ActivityContext activityContext, System.Activities.Activity compiledRoot, bool forImplementation, int compiledDataContextCount) {
                return System.Activities.XamlIntegration.CompiledDataContext.GetCompiledDataContextCache(dataContextActivities, activityContext, compiledRoot, forImplementation, compiledDataContextCount);
            }
            
            public new virtual void SetLocationsOffset(int locationsOffsetValue) {
                locationsOffset = locationsOffsetValue;
                base.SetLocationsOffset(locationsOffset);
            }
            
            public new static bool Validate(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences, bool validateLocationCount, int offset) {
                if (((validateLocationCount == true) 
                            && (locationReferences.Count < 1))) {
                    return false;
                }
                if ((validateLocationCount == true)) {
                    offset = (locationReferences.Count - 1);
                }
                expectedLocationsCount = 1;
                if (((locationReferences[(offset + 0)].Name != "para") 
                            || (locationReferences[(offset + 0)].Type != typeof(BOC.GSP.V2.WF.Common.Variable.ActivityPara)))) {
                    return false;
                }
                return WFInstance_TypedDataContext0.Validate(locationReferences, false, offset);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class WFInstance_TypedDataContext1_ForReadOnly : WFInstance_TypedDataContext0_ForReadOnly {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            public WFInstance_TypedDataContext1_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public WFInstance_TypedDataContext1_ForReadOnly(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public WFInstance_TypedDataContext1_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            protected BOC.GSP.V2.WF.Common.Variable.ActivityPara para {
                get {
                    return ((BOC.GSP.V2.WF.Common.Variable.ActivityPara)(this.GetVariableValue((0 + locationsOffset))));
                }
            }
            
            internal new static System.Activities.XamlIntegration.CompiledDataContext[] GetCompiledDataContextCacheHelper(object dataContextActivities, System.Activities.ActivityContext activityContext, System.Activities.Activity compiledRoot, bool forImplementation, int compiledDataContextCount) {
                return System.Activities.XamlIntegration.CompiledDataContext.GetCompiledDataContextCache(dataContextActivities, activityContext, compiledRoot, forImplementation, compiledDataContextCount);
            }
            
            public new virtual void SetLocationsOffset(int locationsOffsetValue) {
                locationsOffset = locationsOffsetValue;
                base.SetLocationsOffset(locationsOffset);
            }
            
            public new static bool Validate(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences, bool validateLocationCount, int offset) {
                if (((validateLocationCount == true) 
                            && (locationReferences.Count < 1))) {
                    return false;
                }
                if ((validateLocationCount == true)) {
                    offset = (locationReferences.Count - 1);
                }
                expectedLocationsCount = 1;
                if (((locationReferences[(offset + 0)].Name != "para") 
                            || (locationReferences[(offset + 0)].Type != typeof(BOC.GSP.V2.WF.Common.Variable.ActivityPara)))) {
                    return false;
                }
                return WFInstance_TypedDataContext0_ForReadOnly.Validate(locationReferences, false, offset);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class WFInstance_TypedDataContext2 : WFInstance_TypedDataContext1 {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            public WFInstance_TypedDataContext2(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public WFInstance_TypedDataContext2(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public WFInstance_TypedDataContext2(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            protected BOC.GSP.V2.WF.Common.Variable.ActivityPara varPara {
                get {
                    return ((BOC.GSP.V2.WF.Common.Variable.ActivityPara)(this.GetVariableValue((1 + locationsOffset))));
                }
                set {
                    this.SetVariableValue((1 + locationsOffset), value);
                }
            }
            
            internal new static System.Activities.XamlIntegration.CompiledDataContext[] GetCompiledDataContextCacheHelper(object dataContextActivities, System.Activities.ActivityContext activityContext, System.Activities.Activity compiledRoot, bool forImplementation, int compiledDataContextCount) {
                return System.Activities.XamlIntegration.CompiledDataContext.GetCompiledDataContextCache(dataContextActivities, activityContext, compiledRoot, forImplementation, compiledDataContextCount);
            }
            
            public new virtual void SetLocationsOffset(int locationsOffsetValue) {
                locationsOffset = locationsOffsetValue;
                base.SetLocationsOffset(locationsOffset);
            }
            
            public new static bool Validate(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences, bool validateLocationCount, int offset) {
                if (((validateLocationCount == true) 
                            && (locationReferences.Count < 2))) {
                    return false;
                }
                if ((validateLocationCount == true)) {
                    offset = (locationReferences.Count - 2);
                }
                expectedLocationsCount = 2;
                if (((locationReferences[(offset + 1)].Name != "varPara") 
                            || (locationReferences[(offset + 1)].Type != typeof(BOC.GSP.V2.WF.Common.Variable.ActivityPara)))) {
                    return false;
                }
                return WFInstance_TypedDataContext1.Validate(locationReferences, false, offset);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class WFInstance_TypedDataContext2_ForReadOnly : WFInstance_TypedDataContext1_ForReadOnly {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            public WFInstance_TypedDataContext2_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public WFInstance_TypedDataContext2_ForReadOnly(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public WFInstance_TypedDataContext2_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            protected BOC.GSP.V2.WF.Common.Variable.ActivityPara varPara {
                get {
                    return ((BOC.GSP.V2.WF.Common.Variable.ActivityPara)(this.GetVariableValue((1 + locationsOffset))));
                }
            }
            
            internal new static System.Activities.XamlIntegration.CompiledDataContext[] GetCompiledDataContextCacheHelper(object dataContextActivities, System.Activities.ActivityContext activityContext, System.Activities.Activity compiledRoot, bool forImplementation, int compiledDataContextCount) {
                return System.Activities.XamlIntegration.CompiledDataContext.GetCompiledDataContextCache(dataContextActivities, activityContext, compiledRoot, forImplementation, compiledDataContextCount);
            }
            
            public new virtual void SetLocationsOffset(int locationsOffsetValue) {
                locationsOffset = locationsOffsetValue;
                base.SetLocationsOffset(locationsOffset);
            }
            
            internal System.Linq.Expressions.Expression @__Expr1GetTree() {
                
                #line 250 "E:\WORKFOLDER\中国银行CRM\04 CODE\BOC.GSP.V2.V3\BOCGSP2PROJECT\BOC.GSP.V2\WF\ENGINE\BOC.GSP.V2.WF.ENGINE\WFINSTANCE.XAML"
                System.Linq.Expressions.Expression<System.Func<BOC.GSP.V2.WF.Common.Variable.ActivityPara>> expression = () => 
          para.clone();
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public BOC.GSP.V2.WF.Common.Variable.ActivityPara @__Expr1Get() {
                
                #line 250 "E:\WORKFOLDER\中国银行CRM\04 CODE\BOC.GSP.V2.V3\BOCGSP2PROJECT\BOC.GSP.V2\WF\ENGINE\BOC.GSP.V2.WF.ENGINE\WFINSTANCE.XAML"
                return 
          para.clone();
                
                #line default
                #line hidden
            }
            
            public BOC.GSP.V2.WF.Common.Variable.ActivityPara ValueType___Expr1Get() {
                this.GetValueTypeValues();
                return this.@__Expr1Get();
            }
            
            public new static bool Validate(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences, bool validateLocationCount, int offset) {
                if (((validateLocationCount == true) 
                            && (locationReferences.Count < 2))) {
                    return false;
                }
                if ((validateLocationCount == true)) {
                    offset = (locationReferences.Count - 2);
                }
                expectedLocationsCount = 2;
                if (((locationReferences[(offset + 1)].Name != "varPara") 
                            || (locationReferences[(offset + 1)].Type != typeof(BOC.GSP.V2.WF.Common.Variable.ActivityPara)))) {
                    return false;
                }
                return WFInstance_TypedDataContext1_ForReadOnly.Validate(locationReferences, false, offset);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class WFInstance_TypedDataContext3 : WFInstance_TypedDataContext2 {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            public WFInstance_TypedDataContext3(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public WFInstance_TypedDataContext3(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public WFInstance_TypedDataContext3(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            internal new static System.Activities.XamlIntegration.CompiledDataContext[] GetCompiledDataContextCacheHelper(object dataContextActivities, System.Activities.ActivityContext activityContext, System.Activities.Activity compiledRoot, bool forImplementation, int compiledDataContextCount) {
                return System.Activities.XamlIntegration.CompiledDataContext.GetCompiledDataContextCache(dataContextActivities, activityContext, compiledRoot, forImplementation, compiledDataContextCount);
            }
            
            public new virtual void SetLocationsOffset(int locationsOffsetValue) {
                locationsOffset = locationsOffsetValue;
                base.SetLocationsOffset(locationsOffset);
            }
            
            internal System.Linq.Expressions.Expression @__Expr3GetTree() {
                
                #line 70 "E:\WORKFOLDER\中国银行CRM\04 CODE\BOC.GSP.V2.V3\BOCGSP2PROJECT\BOC.GSP.V2\WF\ENGINE\BOC.GSP.V2.WF.ENGINE\WFINSTANCE.XAML"
                System.Linq.Expressions.Expression<System.Func<BOC.GSP.V2.WF.Common.Variable.ActivityPara>> expression = () => 
                    para;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public BOC.GSP.V2.WF.Common.Variable.ActivityPara @__Expr3Get() {
                
                #line 70 "E:\WORKFOLDER\中国银行CRM\04 CODE\BOC.GSP.V2.V3\BOCGSP2PROJECT\BOC.GSP.V2\WF\ENGINE\BOC.GSP.V2.WF.ENGINE\WFINSTANCE.XAML"
                return 
                    para;
                
                #line default
                #line hidden
            }
            
            public BOC.GSP.V2.WF.Common.Variable.ActivityPara ValueType___Expr3Get() {
                this.GetValueTypeValues();
                return this.@__Expr3Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr3Set(BOC.GSP.V2.WF.Common.Variable.ActivityPara value) {
                
                #line 70 "E:\WORKFOLDER\中国银行CRM\04 CODE\BOC.GSP.V2.V3\BOCGSP2PROJECT\BOC.GSP.V2\WF\ENGINE\BOC.GSP.V2.WF.ENGINE\WFINSTANCE.XAML"
                
                    para = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr3Set(BOC.GSP.V2.WF.Common.Variable.ActivityPara value) {
                this.GetValueTypeValues();
                this.@__Expr3Set(value);
                this.SetValueTypeValues();
            }
            
            public new static bool Validate(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences, bool validateLocationCount, int offset) {
                if (((validateLocationCount == true) 
                            && (locationReferences.Count < 2))) {
                    return false;
                }
                if ((validateLocationCount == true)) {
                    offset = (locationReferences.Count - 2);
                }
                expectedLocationsCount = 2;
                return WFInstance_TypedDataContext2.Validate(locationReferences, false, offset);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class WFInstance_TypedDataContext3_ForReadOnly : WFInstance_TypedDataContext2_ForReadOnly {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            public WFInstance_TypedDataContext3_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public WFInstance_TypedDataContext3_ForReadOnly(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public WFInstance_TypedDataContext3_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            internal new static System.Activities.XamlIntegration.CompiledDataContext[] GetCompiledDataContextCacheHelper(object dataContextActivities, System.Activities.ActivityContext activityContext, System.Activities.Activity compiledRoot, bool forImplementation, int compiledDataContextCount) {
                return System.Activities.XamlIntegration.CompiledDataContext.GetCompiledDataContextCache(dataContextActivities, activityContext, compiledRoot, forImplementation, compiledDataContextCount);
            }
            
            public new virtual void SetLocationsOffset(int locationsOffsetValue) {
                locationsOffset = locationsOffsetValue;
                base.SetLocationsOffset(locationsOffset);
            }
            
            internal System.Linq.Expressions.Expression @__Expr2GetTree() {
                
                #line 63 "E:\WORKFOLDER\中国银行CRM\04 CODE\BOC.GSP.V2.V3\BOCGSP2PROJECT\BOC.GSP.V2\WF\ENGINE\BOC.GSP.V2.WF.ENGINE\WFINSTANCE.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                para.ActType==1;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr2Get() {
                
                #line 63 "E:\WORKFOLDER\中国银行CRM\04 CODE\BOC.GSP.V2.V3\BOCGSP2PROJECT\BOC.GSP.V2\WF\ENGINE\BOC.GSP.V2.WF.ENGINE\WFINSTANCE.XAML"
                return 
                para.ActType==1;
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr2Get() {
                this.GetValueTypeValues();
                return this.@__Expr2Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr4GetTree() {
                
                #line 79 "E:\WORKFOLDER\中国银行CRM\04 CODE\BOC.GSP.V2.V3\BOCGSP2PROJECT\BOC.GSP.V2\WF\ENGINE\BOC.GSP.V2.WF.ENGINE\WFINSTANCE.XAML"
                System.Linq.Expressions.Expression<System.Func<BOC.GSP.V2.WF.Common.Variable.ActivityPara>> expression = () => 
                    para;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public BOC.GSP.V2.WF.Common.Variable.ActivityPara @__Expr4Get() {
                
                #line 79 "E:\WORKFOLDER\中国银行CRM\04 CODE\BOC.GSP.V2.V3\BOCGSP2PROJECT\BOC.GSP.V2\WF\ENGINE\BOC.GSP.V2.WF.ENGINE\WFINSTANCE.XAML"
                return 
                    para;
                
                #line default
                #line hidden
            }
            
            public BOC.GSP.V2.WF.Common.Variable.ActivityPara ValueType___Expr4Get() {
                this.GetValueTypeValues();
                return this.@__Expr4Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr5GetTree() {
                
                #line 91 "E:\WORKFOLDER\中国银行CRM\04 CODE\BOC.GSP.V2.V3\BOCGSP2PROJECT\BOC.GSP.V2\WF\ENGINE\BOC.GSP.V2.WF.ENGINE\WFINSTANCE.XAML"
                System.Linq.Expressions.Expression<System.Func<BOC.GSP.V2.WF.Common.Variable.ActivityPara>> expression = () => 
                  para;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public BOC.GSP.V2.WF.Common.Variable.ActivityPara @__Expr5Get() {
                
                #line 91 "E:\WORKFOLDER\中国银行CRM\04 CODE\BOC.GSP.V2.V3\BOCGSP2PROJECT\BOC.GSP.V2\WF\ENGINE\BOC.GSP.V2.WF.ENGINE\WFINSTANCE.XAML"
                return 
                  para;
                
                #line default
                #line hidden
            }
            
            public BOC.GSP.V2.WF.Common.Variable.ActivityPara ValueType___Expr5Get() {
                this.GetValueTypeValues();
                return this.@__Expr5Get();
            }
            
            public new static bool Validate(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences, bool validateLocationCount, int offset) {
                if (((validateLocationCount == true) 
                            && (locationReferences.Count < 2))) {
                    return false;
                }
                if ((validateLocationCount == true)) {
                    offset = (locationReferences.Count - 2);
                }
                expectedLocationsCount = 2;
                return WFInstance_TypedDataContext2_ForReadOnly.Validate(locationReferences, false, offset);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class WFInstance_TypedDataContext4 : WFInstance_TypedDataContext2 {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            public WFInstance_TypedDataContext4(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public WFInstance_TypedDataContext4(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public WFInstance_TypedDataContext4(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            internal new static System.Activities.XamlIntegration.CompiledDataContext[] GetCompiledDataContextCacheHelper(object dataContextActivities, System.Activities.ActivityContext activityContext, System.Activities.Activity compiledRoot, bool forImplementation, int compiledDataContextCount) {
                return System.Activities.XamlIntegration.CompiledDataContext.GetCompiledDataContextCache(dataContextActivities, activityContext, compiledRoot, forImplementation, compiledDataContextCount);
            }
            
            public new virtual void SetLocationsOffset(int locationsOffsetValue) {
                locationsOffset = locationsOffsetValue;
                base.SetLocationsOffset(locationsOffset);
            }
            
            public new static bool Validate(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences, bool validateLocationCount, int offset) {
                if (((validateLocationCount == true) 
                            && (locationReferences.Count < 2))) {
                    return false;
                }
                if ((validateLocationCount == true)) {
                    offset = (locationReferences.Count - 2);
                }
                expectedLocationsCount = 2;
                return WFInstance_TypedDataContext2.Validate(locationReferences, false, offset);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class WFInstance_TypedDataContext4_ForReadOnly : WFInstance_TypedDataContext2_ForReadOnly {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            public WFInstance_TypedDataContext4_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public WFInstance_TypedDataContext4_ForReadOnly(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public WFInstance_TypedDataContext4_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            internal new static System.Activities.XamlIntegration.CompiledDataContext[] GetCompiledDataContextCacheHelper(object dataContextActivities, System.Activities.ActivityContext activityContext, System.Activities.Activity compiledRoot, bool forImplementation, int compiledDataContextCount) {
                return System.Activities.XamlIntegration.CompiledDataContext.GetCompiledDataContextCache(dataContextActivities, activityContext, compiledRoot, forImplementation, compiledDataContextCount);
            }
            
            public new virtual void SetLocationsOffset(int locationsOffsetValue) {
                locationsOffset = locationsOffsetValue;
                base.SetLocationsOffset(locationsOffset);
            }
            
            internal System.Linq.Expressions.Expression @__Expr6GetTree() {
                
                #line 106 "E:\WORKFOLDER\中国银行CRM\04 CODE\BOC.GSP.V2.V3\BOCGSP2PROJECT\BOC.GSP.V2\WF\ENGINE\BOC.GSP.V2.WF.ENGINE\WFINSTANCE.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                          para.ActType!=2;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr6Get() {
                
                #line 106 "E:\WORKFOLDER\中国银行CRM\04 CODE\BOC.GSP.V2.V3\BOCGSP2PROJECT\BOC.GSP.V2\WF\ENGINE\BOC.GSP.V2.WF.ENGINE\WFINSTANCE.XAML"
                return 
                          para.ActType!=2;
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr6Get() {
                this.GetValueTypeValues();
                return this.@__Expr6Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr7GetTree() {
                
                #line 114 "E:\WORKFOLDER\中国银行CRM\04 CODE\BOC.GSP.V2.V3\BOCGSP2PROJECT\BOC.GSP.V2\WF\ENGINE\BOC.GSP.V2.WF.ENGINE\WFINSTANCE.XAML"
                System.Linq.Expressions.Expression<System.Func<System.Collections.Generic.IEnumerable<BOC.GSP.V2.WF.Common.Variable.NextActivity>>> expression = () => 
                                para.NextAct;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public System.Collections.Generic.IEnumerable<BOC.GSP.V2.WF.Common.Variable.NextActivity> @__Expr7Get() {
                
                #line 114 "E:\WORKFOLDER\中国银行CRM\04 CODE\BOC.GSP.V2.V3\BOCGSP2PROJECT\BOC.GSP.V2\WF\ENGINE\BOC.GSP.V2.WF.ENGINE\WFINSTANCE.XAML"
                return 
                                para.NextAct;
                
                #line default
                #line hidden
            }
            
            public System.Collections.Generic.IEnumerable<BOC.GSP.V2.WF.Common.Variable.NextActivity> ValueType___Expr7Get() {
                this.GetValueTypeValues();
                return this.@__Expr7Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr23GetTree() {
                
                #line 230 "E:\WORKFOLDER\中国银行CRM\04 CODE\BOC.GSP.V2.V3\BOCGSP2PROJECT\BOC.GSP.V2\WF\ENGINE\BOC.GSP.V2.WF.ENGINE\WFINSTANCE.XAML"
                System.Linq.Expressions.Expression<System.Func<BOC.GSP.V2.WF.Common.Variable.ActivityPara>> expression = () => 
                                para;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public BOC.GSP.V2.WF.Common.Variable.ActivityPara @__Expr23Get() {
                
                #line 230 "E:\WORKFOLDER\中国银行CRM\04 CODE\BOC.GSP.V2.V3\BOCGSP2PROJECT\BOC.GSP.V2\WF\ENGINE\BOC.GSP.V2.WF.ENGINE\WFINSTANCE.XAML"
                return 
                                para;
                
                #line default
                #line hidden
            }
            
            public BOC.GSP.V2.WF.Common.Variable.ActivityPara ValueType___Expr23Get() {
                this.GetValueTypeValues();
                return this.@__Expr23Get();
            }
            
            public new static bool Validate(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences, bool validateLocationCount, int offset) {
                if (((validateLocationCount == true) 
                            && (locationReferences.Count < 2))) {
                    return false;
                }
                if ((validateLocationCount == true)) {
                    offset = (locationReferences.Count - 2);
                }
                expectedLocationsCount = 2;
                return WFInstance_TypedDataContext2_ForReadOnly.Validate(locationReferences, false, offset);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class WFInstance_TypedDataContext5 : WFInstance_TypedDataContext4 {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            public WFInstance_TypedDataContext5(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public WFInstance_TypedDataContext5(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public WFInstance_TypedDataContext5(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            protected BOC.GSP.V2.WF.Common.Variable.NextActivity item {
                get {
                    return ((BOC.GSP.V2.WF.Common.Variable.NextActivity)(this.GetVariableValue((2 + locationsOffset))));
                }
                set {
                    this.SetVariableValue((2 + locationsOffset), value);
                }
            }
            
            internal new static System.Activities.XamlIntegration.CompiledDataContext[] GetCompiledDataContextCacheHelper(object dataContextActivities, System.Activities.ActivityContext activityContext, System.Activities.Activity compiledRoot, bool forImplementation, int compiledDataContextCount) {
                return System.Activities.XamlIntegration.CompiledDataContext.GetCompiledDataContextCache(dataContextActivities, activityContext, compiledRoot, forImplementation, compiledDataContextCount);
            }
            
            public new virtual void SetLocationsOffset(int locationsOffsetValue) {
                locationsOffset = locationsOffsetValue;
                base.SetLocationsOffset(locationsOffset);
            }
            
            public new static bool Validate(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences, bool validateLocationCount, int offset) {
                if (((validateLocationCount == true) 
                            && (locationReferences.Count < 3))) {
                    return false;
                }
                if ((validateLocationCount == true)) {
                    offset = (locationReferences.Count - 3);
                }
                expectedLocationsCount = 3;
                if (((locationReferences[(offset + 2)].Name != "item") 
                            || (locationReferences[(offset + 2)].Type != typeof(BOC.GSP.V2.WF.Common.Variable.NextActivity)))) {
                    return false;
                }
                return WFInstance_TypedDataContext4.Validate(locationReferences, false, offset);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class WFInstance_TypedDataContext5_ForReadOnly : WFInstance_TypedDataContext4_ForReadOnly {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            public WFInstance_TypedDataContext5_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public WFInstance_TypedDataContext5_ForReadOnly(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public WFInstance_TypedDataContext5_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            protected BOC.GSP.V2.WF.Common.Variable.NextActivity item {
                get {
                    return ((BOC.GSP.V2.WF.Common.Variable.NextActivity)(this.GetVariableValue((2 + locationsOffset))));
                }
            }
            
            internal new static System.Activities.XamlIntegration.CompiledDataContext[] GetCompiledDataContextCacheHelper(object dataContextActivities, System.Activities.ActivityContext activityContext, System.Activities.Activity compiledRoot, bool forImplementation, int compiledDataContextCount) {
                return System.Activities.XamlIntegration.CompiledDataContext.GetCompiledDataContextCache(dataContextActivities, activityContext, compiledRoot, forImplementation, compiledDataContextCount);
            }
            
            public new virtual void SetLocationsOffset(int locationsOffsetValue) {
                locationsOffset = locationsOffsetValue;
                base.SetLocationsOffset(locationsOffset);
            }
            
            public new static bool Validate(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences, bool validateLocationCount, int offset) {
                if (((validateLocationCount == true) 
                            && (locationReferences.Count < 3))) {
                    return false;
                }
                if ((validateLocationCount == true)) {
                    offset = (locationReferences.Count - 3);
                }
                expectedLocationsCount = 3;
                if (((locationReferences[(offset + 2)].Name != "item") 
                            || (locationReferences[(offset + 2)].Type != typeof(BOC.GSP.V2.WF.Common.Variable.NextActivity)))) {
                    return false;
                }
                return WFInstance_TypedDataContext4_ForReadOnly.Validate(locationReferences, false, offset);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class WFInstance_TypedDataContext6 : WFInstance_TypedDataContext5 {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            public WFInstance_TypedDataContext6(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public WFInstance_TypedDataContext6(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public WFInstance_TypedDataContext6(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            protected BOC.GSP.V2.WF.Common.Variable.ActivityPara nextPara {
                get {
                    return ((BOC.GSP.V2.WF.Common.Variable.ActivityPara)(this.GetVariableValue((3 + locationsOffset))));
                }
                set {
                    this.SetVariableValue((3 + locationsOffset), value);
                }
            }
            
            internal new static System.Activities.XamlIntegration.CompiledDataContext[] GetCompiledDataContextCacheHelper(object dataContextActivities, System.Activities.ActivityContext activityContext, System.Activities.Activity compiledRoot, bool forImplementation, int compiledDataContextCount) {
                return System.Activities.XamlIntegration.CompiledDataContext.GetCompiledDataContextCache(dataContextActivities, activityContext, compiledRoot, forImplementation, compiledDataContextCount);
            }
            
            public new virtual void SetLocationsOffset(int locationsOffsetValue) {
                locationsOffset = locationsOffsetValue;
                base.SetLocationsOffset(locationsOffset);
            }
            
            internal System.Linq.Expressions.Expression @__Expr10GetTree() {
                
                #line 132 "E:\WORKFOLDER\中国银行CRM\04 CODE\BOC.GSP.V2.V3\BOCGSP2PROJECT\BOC.GSP.V2\WF\ENGINE\BOC.GSP.V2.WF.ENGINE\WFINSTANCE.XAML"
                System.Linq.Expressions.Expression<System.Func<System.Guid>> expression = () => 
                                      nextPara.ProcessID;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public System.Guid @__Expr10Get() {
                
                #line 132 "E:\WORKFOLDER\中国银行CRM\04 CODE\BOC.GSP.V2.V3\BOCGSP2PROJECT\BOC.GSP.V2\WF\ENGINE\BOC.GSP.V2.WF.ENGINE\WFINSTANCE.XAML"
                return 
                                      nextPara.ProcessID;
                
                #line default
                #line hidden
            }
            
            public System.Guid ValueType___Expr10Get() {
                this.GetValueTypeValues();
                return this.@__Expr10Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr10Set(System.Guid value) {
                
                #line 132 "E:\WORKFOLDER\中国银行CRM\04 CODE\BOC.GSP.V2.V3\BOCGSP2PROJECT\BOC.GSP.V2\WF\ENGINE\BOC.GSP.V2.WF.ENGINE\WFINSTANCE.XAML"
                
                                      nextPara.ProcessID = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr10Set(System.Guid value) {
                this.GetValueTypeValues();
                this.@__Expr10Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr12GetTree() {
                
                #line 144 "E:\WORKFOLDER\中国银行CRM\04 CODE\BOC.GSP.V2.V3\BOCGSP2PROJECT\BOC.GSP.V2\WF\ENGINE\BOC.GSP.V2.WF.ENGINE\WFINSTANCE.XAML"
                System.Linq.Expressions.Expression<System.Func<System.Guid>> expression = () => 
                                      nextPara.ProcessInstanceId;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public System.Guid @__Expr12Get() {
                
                #line 144 "E:\WORKFOLDER\中国银行CRM\04 CODE\BOC.GSP.V2.V3\BOCGSP2PROJECT\BOC.GSP.V2\WF\ENGINE\BOC.GSP.V2.WF.ENGINE\WFINSTANCE.XAML"
                return 
                                      nextPara.ProcessInstanceId;
                
                #line default
                #line hidden
            }
            
            public System.Guid ValueType___Expr12Get() {
                this.GetValueTypeValues();
                return this.@__Expr12Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr12Set(System.Guid value) {
                
                #line 144 "E:\WORKFOLDER\中国银行CRM\04 CODE\BOC.GSP.V2.V3\BOCGSP2PROJECT\BOC.GSP.V2\WF\ENGINE\BOC.GSP.V2.WF.ENGINE\WFINSTANCE.XAML"
                
                                      nextPara.ProcessInstanceId = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr12Set(System.Guid value) {
                this.GetValueTypeValues();
                this.@__Expr12Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr14GetTree() {
                
                #line 156 "E:\WORKFOLDER\中国银行CRM\04 CODE\BOC.GSP.V2.V3\BOCGSP2PROJECT\BOC.GSP.V2\WF\ENGINE\BOC.GSP.V2.WF.ENGINE\WFINSTANCE.XAML"
                System.Linq.Expressions.Expression<System.Func<int>> expression = () => 
                                      nextPara.ActId;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public int @__Expr14Get() {
                
                #line 156 "E:\WORKFOLDER\中国银行CRM\04 CODE\BOC.GSP.V2.V3\BOCGSP2PROJECT\BOC.GSP.V2\WF\ENGINE\BOC.GSP.V2.WF.ENGINE\WFINSTANCE.XAML"
                return 
                                      nextPara.ActId;
                
                #line default
                #line hidden
            }
            
            public int ValueType___Expr14Get() {
                this.GetValueTypeValues();
                return this.@__Expr14Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr14Set(int value) {
                
                #line 156 "E:\WORKFOLDER\中国银行CRM\04 CODE\BOC.GSP.V2.V3\BOCGSP2PROJECT\BOC.GSP.V2\WF\ENGINE\BOC.GSP.V2.WF.ENGINE\WFINSTANCE.XAML"
                
                                      nextPara.ActId = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr14Set(int value) {
                this.GetValueTypeValues();
                this.@__Expr14Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr16GetTree() {
                
                #line 168 "E:\WORKFOLDER\中国银行CRM\04 CODE\BOC.GSP.V2.V3\BOCGSP2PROJECT\BOC.GSP.V2\WF\ENGINE\BOC.GSP.V2.WF.ENGINE\WFINSTANCE.XAML"
                System.Linq.Expressions.Expression<System.Func<int>> expression = () => 
                                      nextPara.ActType;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public int @__Expr16Get() {
                
                #line 168 "E:\WORKFOLDER\中国银行CRM\04 CODE\BOC.GSP.V2.V3\BOCGSP2PROJECT\BOC.GSP.V2\WF\ENGINE\BOC.GSP.V2.WF.ENGINE\WFINSTANCE.XAML"
                return 
                                      nextPara.ActType;
                
                #line default
                #line hidden
            }
            
            public int ValueType___Expr16Get() {
                this.GetValueTypeValues();
                return this.@__Expr16Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr16Set(int value) {
                
                #line 168 "E:\WORKFOLDER\中国银行CRM\04 CODE\BOC.GSP.V2.V3\BOCGSP2PROJECT\BOC.GSP.V2\WF\ENGINE\BOC.GSP.V2.WF.ENGINE\WFINSTANCE.XAML"
                
                                      nextPara.ActType = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr16Set(int value) {
                this.GetValueTypeValues();
                this.@__Expr16Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr17GetTree() {
                
                #line 180 "E:\WORKFOLDER\中国银行CRM\04 CODE\BOC.GSP.V2.V3\BOCGSP2PROJECT\BOC.GSP.V2\WF\ENGINE\BOC.GSP.V2.WF.ENGINE\WFINSTANCE.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                                      nextPara.ADUser;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr17Get() {
                
                #line 180 "E:\WORKFOLDER\中国银行CRM\04 CODE\BOC.GSP.V2.V3\BOCGSP2PROJECT\BOC.GSP.V2\WF\ENGINE\BOC.GSP.V2.WF.ENGINE\WFINSTANCE.XAML"
                return 
                                      nextPara.ADUser;
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr17Get() {
                this.GetValueTypeValues();
                return this.@__Expr17Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr17Set(string value) {
                
                #line 180 "E:\WORKFOLDER\中国银行CRM\04 CODE\BOC.GSP.V2.V3\BOCGSP2PROJECT\BOC.GSP.V2\WF\ENGINE\BOC.GSP.V2.WF.ENGINE\WFINSTANCE.XAML"
                
                                      nextPara.ADUser = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr17Set(string value) {
                this.GetValueTypeValues();
                this.@__Expr17Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr19GetTree() {
                
                #line 190 "E:\WORKFOLDER\中国银行CRM\04 CODE\BOC.GSP.V2.V3\BOCGSP2PROJECT\BOC.GSP.V2\WF\ENGINE\BOC.GSP.V2.WF.ENGINE\WFINSTANCE.XAML"
                System.Linq.Expressions.Expression<System.Func<System.Collections.Generic.List<BOC.GSP.V2.WF.Common.Variable.NextActivity>>> expression = () => 
                                      nextPara.NextAct;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public System.Collections.Generic.List<BOC.GSP.V2.WF.Common.Variable.NextActivity> @__Expr19Get() {
                
                #line 190 "E:\WORKFOLDER\中国银行CRM\04 CODE\BOC.GSP.V2.V3\BOCGSP2PROJECT\BOC.GSP.V2\WF\ENGINE\BOC.GSP.V2.WF.ENGINE\WFINSTANCE.XAML"
                return 
                                      nextPara.NextAct;
                
                #line default
                #line hidden
            }
            
            public System.Collections.Generic.List<BOC.GSP.V2.WF.Common.Variable.NextActivity> ValueType___Expr19Get() {
                this.GetValueTypeValues();
                return this.@__Expr19Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr19Set(System.Collections.Generic.List<BOC.GSP.V2.WF.Common.Variable.NextActivity> value) {
                
                #line 190 "E:\WORKFOLDER\中国银行CRM\04 CODE\BOC.GSP.V2.V3\BOCGSP2PROJECT\BOC.GSP.V2\WF\ENGINE\BOC.GSP.V2.WF.ENGINE\WFINSTANCE.XAML"
                
                                      nextPara.NextAct = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr19Set(System.Collections.Generic.List<BOC.GSP.V2.WF.Common.Variable.NextActivity> value) {
                this.GetValueTypeValues();
                this.@__Expr19Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr21GetTree() {
                
                #line 202 "E:\WORKFOLDER\中国银行CRM\04 CODE\BOC.GSP.V2.V3\BOCGSP2PROJECT\BOC.GSP.V2\WF\ENGINE\BOC.GSP.V2.WF.ENGINE\WFINSTANCE.XAML"
                System.Linq.Expressions.Expression<System.Func<int>> expression = () => 
                                      nextPara.ExecType;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public int @__Expr21Get() {
                
                #line 202 "E:\WORKFOLDER\中国银行CRM\04 CODE\BOC.GSP.V2.V3\BOCGSP2PROJECT\BOC.GSP.V2\WF\ENGINE\BOC.GSP.V2.WF.ENGINE\WFINSTANCE.XAML"
                return 
                                      nextPara.ExecType;
                
                #line default
                #line hidden
            }
            
            public int ValueType___Expr21Get() {
                this.GetValueTypeValues();
                return this.@__Expr21Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr21Set(int value) {
                
                #line 202 "E:\WORKFOLDER\中国银行CRM\04 CODE\BOC.GSP.V2.V3\BOCGSP2PROJECT\BOC.GSP.V2\WF\ENGINE\BOC.GSP.V2.WF.ENGINE\WFINSTANCE.XAML"
                
                                      nextPara.ExecType = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr21Set(int value) {
                this.GetValueTypeValues();
                this.@__Expr21Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr22GetTree() {
                
                #line 215 "E:\WORKFOLDER\中国银行CRM\04 CODE\BOC.GSP.V2.V3\BOCGSP2PROJECT\BOC.GSP.V2\WF\ENGINE\BOC.GSP.V2.WF.ENGINE\WFINSTANCE.XAML"
                System.Linq.Expressions.Expression<System.Func<BOC.GSP.V2.WF.Common.Variable.ActivityPara>> expression = () => 
                                      nextPara;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public BOC.GSP.V2.WF.Common.Variable.ActivityPara @__Expr22Get() {
                
                #line 215 "E:\WORKFOLDER\中国银行CRM\04 CODE\BOC.GSP.V2.V3\BOCGSP2PROJECT\BOC.GSP.V2\WF\ENGINE\BOC.GSP.V2.WF.ENGINE\WFINSTANCE.XAML"
                return 
                                      nextPara;
                
                #line default
                #line hidden
            }
            
            public BOC.GSP.V2.WF.Common.Variable.ActivityPara ValueType___Expr22Get() {
                this.GetValueTypeValues();
                return this.@__Expr22Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr22Set(BOC.GSP.V2.WF.Common.Variable.ActivityPara value) {
                
                #line 215 "E:\WORKFOLDER\中国银行CRM\04 CODE\BOC.GSP.V2.V3\BOCGSP2PROJECT\BOC.GSP.V2\WF\ENGINE\BOC.GSP.V2.WF.ENGINE\WFINSTANCE.XAML"
                
                                      nextPara = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr22Set(BOC.GSP.V2.WF.Common.Variable.ActivityPara value) {
                this.GetValueTypeValues();
                this.@__Expr22Set(value);
                this.SetValueTypeValues();
            }
            
            public new static bool Validate(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences, bool validateLocationCount, int offset) {
                if (((validateLocationCount == true) 
                            && (locationReferences.Count < 4))) {
                    return false;
                }
                if ((validateLocationCount == true)) {
                    offset = (locationReferences.Count - 4);
                }
                expectedLocationsCount = 4;
                if (((locationReferences[(offset + 3)].Name != "nextPara") 
                            || (locationReferences[(offset + 3)].Type != typeof(BOC.GSP.V2.WF.Common.Variable.ActivityPara)))) {
                    return false;
                }
                return WFInstance_TypedDataContext5.Validate(locationReferences, false, offset);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class WFInstance_TypedDataContext6_ForReadOnly : WFInstance_TypedDataContext5_ForReadOnly {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            public WFInstance_TypedDataContext6_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public WFInstance_TypedDataContext6_ForReadOnly(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public WFInstance_TypedDataContext6_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            protected BOC.GSP.V2.WF.Common.Variable.ActivityPara nextPara {
                get {
                    return ((BOC.GSP.V2.WF.Common.Variable.ActivityPara)(this.GetVariableValue((3 + locationsOffset))));
                }
            }
            
            internal new static System.Activities.XamlIntegration.CompiledDataContext[] GetCompiledDataContextCacheHelper(object dataContextActivities, System.Activities.ActivityContext activityContext, System.Activities.Activity compiledRoot, bool forImplementation, int compiledDataContextCount) {
                return System.Activities.XamlIntegration.CompiledDataContext.GetCompiledDataContextCache(dataContextActivities, activityContext, compiledRoot, forImplementation, compiledDataContextCount);
            }
            
            public new virtual void SetLocationsOffset(int locationsOffsetValue) {
                locationsOffset = locationsOffsetValue;
                base.SetLocationsOffset(locationsOffset);
            }
            
            internal System.Linq.Expressions.Expression @__Expr8GetTree() {
                
                #line 125 "E:\WORKFOLDER\中国银行CRM\04 CODE\BOC.GSP.V2.V3\BOCGSP2PROJECT\BOC.GSP.V2\WF\ENGINE\BOC.GSP.V2.WF.ENGINE\WFINSTANCE.XAML"
                System.Linq.Expressions.Expression<System.Func<BOC.GSP.V2.WF.Common.Variable.ActivityPara>> expression = () => 
                                      para.clone();
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public BOC.GSP.V2.WF.Common.Variable.ActivityPara @__Expr8Get() {
                
                #line 125 "E:\WORKFOLDER\中国银行CRM\04 CODE\BOC.GSP.V2.V3\BOCGSP2PROJECT\BOC.GSP.V2\WF\ENGINE\BOC.GSP.V2.WF.ENGINE\WFINSTANCE.XAML"
                return 
                                      para.clone();
                
                #line default
                #line hidden
            }
            
            public BOC.GSP.V2.WF.Common.Variable.ActivityPara ValueType___Expr8Get() {
                this.GetValueTypeValues();
                return this.@__Expr8Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr9GetTree() {
                
                #line 137 "E:\WORKFOLDER\中国银行CRM\04 CODE\BOC.GSP.V2.V3\BOCGSP2PROJECT\BOC.GSP.V2\WF\ENGINE\BOC.GSP.V2.WF.ENGINE\WFINSTANCE.XAML"
                System.Linq.Expressions.Expression<System.Func<System.Guid>> expression = () => 
                                      para.ProcessID;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public System.Guid @__Expr9Get() {
                
                #line 137 "E:\WORKFOLDER\中国银行CRM\04 CODE\BOC.GSP.V2.V3\BOCGSP2PROJECT\BOC.GSP.V2\WF\ENGINE\BOC.GSP.V2.WF.ENGINE\WFINSTANCE.XAML"
                return 
                                      para.ProcessID;
                
                #line default
                #line hidden
            }
            
            public System.Guid ValueType___Expr9Get() {
                this.GetValueTypeValues();
                return this.@__Expr9Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr11GetTree() {
                
                #line 149 "E:\WORKFOLDER\中国银行CRM\04 CODE\BOC.GSP.V2.V3\BOCGSP2PROJECT\BOC.GSP.V2\WF\ENGINE\BOC.GSP.V2.WF.ENGINE\WFINSTANCE.XAML"
                System.Linq.Expressions.Expression<System.Func<System.Guid>> expression = () => 
                                      para.ProcessInstanceId;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public System.Guid @__Expr11Get() {
                
                #line 149 "E:\WORKFOLDER\中国银行CRM\04 CODE\BOC.GSP.V2.V3\BOCGSP2PROJECT\BOC.GSP.V2\WF\ENGINE\BOC.GSP.V2.WF.ENGINE\WFINSTANCE.XAML"
                return 
                                      para.ProcessInstanceId;
                
                #line default
                #line hidden
            }
            
            public System.Guid ValueType___Expr11Get() {
                this.GetValueTypeValues();
                return this.@__Expr11Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr13GetTree() {
                
                #line 161 "E:\WORKFOLDER\中国银行CRM\04 CODE\BOC.GSP.V2.V3\BOCGSP2PROJECT\BOC.GSP.V2\WF\ENGINE\BOC.GSP.V2.WF.ENGINE\WFINSTANCE.XAML"
                System.Linq.Expressions.Expression<System.Func<int>> expression = () => 
                                      item.NextActId;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public int @__Expr13Get() {
                
                #line 161 "E:\WORKFOLDER\中国银行CRM\04 CODE\BOC.GSP.V2.V3\BOCGSP2PROJECT\BOC.GSP.V2\WF\ENGINE\BOC.GSP.V2.WF.ENGINE\WFINSTANCE.XAML"
                return 
                                      item.NextActId;
                
                #line default
                #line hidden
            }
            
            public int ValueType___Expr13Get() {
                this.GetValueTypeValues();
                return this.@__Expr13Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr15GetTree() {
                
                #line 173 "E:\WORKFOLDER\中国银行CRM\04 CODE\BOC.GSP.V2.V3\BOCGSP2PROJECT\BOC.GSP.V2\WF\ENGINE\BOC.GSP.V2.WF.ENGINE\WFINSTANCE.XAML"
                System.Linq.Expressions.Expression<System.Func<int>> expression = () => 
                                      item.NextActExecType;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public int @__Expr15Get() {
                
                #line 173 "E:\WORKFOLDER\中国银行CRM\04 CODE\BOC.GSP.V2.V3\BOCGSP2PROJECT\BOC.GSP.V2\WF\ENGINE\BOC.GSP.V2.WF.ENGINE\WFINSTANCE.XAML"
                return 
                                      item.NextActExecType;
                
                #line default
                #line hidden
            }
            
            public int ValueType___Expr15Get() {
                this.GetValueTypeValues();
                return this.@__Expr15Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr18GetTree() {
                
                #line 195 "E:\WORKFOLDER\中国银行CRM\04 CODE\BOC.GSP.V2.V3\BOCGSP2PROJECT\BOC.GSP.V2\WF\ENGINE\BOC.GSP.V2.WF.ENGINE\WFINSTANCE.XAML"
                System.Linq.Expressions.Expression<System.Func<System.Collections.Generic.List<BOC.GSP.V2.WF.Common.Variable.NextActivity>>> expression = () => 
                                      null;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public System.Collections.Generic.List<BOC.GSP.V2.WF.Common.Variable.NextActivity> @__Expr18Get() {
                
                #line 195 "E:\WORKFOLDER\中国银行CRM\04 CODE\BOC.GSP.V2.V3\BOCGSP2PROJECT\BOC.GSP.V2\WF\ENGINE\BOC.GSP.V2.WF.ENGINE\WFINSTANCE.XAML"
                return 
                                      null;
                
                #line default
                #line hidden
            }
            
            public System.Collections.Generic.List<BOC.GSP.V2.WF.Common.Variable.NextActivity> ValueType___Expr18Get() {
                this.GetValueTypeValues();
                return this.@__Expr18Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr20GetTree() {
                
                #line 207 "E:\WORKFOLDER\中国银行CRM\04 CODE\BOC.GSP.V2.V3\BOCGSP2PROJECT\BOC.GSP.V2\WF\ENGINE\BOC.GSP.V2.WF.ENGINE\WFINSTANCE.XAML"
                System.Linq.Expressions.Expression<System.Func<int>> expression = () => 
                                      item.ApproveType;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public int @__Expr20Get() {
                
                #line 207 "E:\WORKFOLDER\中国银行CRM\04 CODE\BOC.GSP.V2.V3\BOCGSP2PROJECT\BOC.GSP.V2\WF\ENGINE\BOC.GSP.V2.WF.ENGINE\WFINSTANCE.XAML"
                return 
                                      item.ApproveType;
                
                #line default
                #line hidden
            }
            
            public int ValueType___Expr20Get() {
                this.GetValueTypeValues();
                return this.@__Expr20Get();
            }
            
            public new static bool Validate(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences, bool validateLocationCount, int offset) {
                if (((validateLocationCount == true) 
                            && (locationReferences.Count < 4))) {
                    return false;
                }
                if ((validateLocationCount == true)) {
                    offset = (locationReferences.Count - 4);
                }
                expectedLocationsCount = 4;
                if (((locationReferences[(offset + 3)].Name != "nextPara") 
                            || (locationReferences[(offset + 3)].Type != typeof(BOC.GSP.V2.WF.Common.Variable.ActivityPara)))) {
                    return false;
                }
                return WFInstance_TypedDataContext5_ForReadOnly.Validate(locationReferences, false, offset);
            }
        }
    }
}
