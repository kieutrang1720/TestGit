//------------------------------------------------------------------------------
// <auto-generated>
//     Dieser Code wurde von einem Tool generiert.
//     Laufzeitversion:4.0.30319.42000
//
//     Änderungen an dieser Datei können falsches Verhalten verursachen und gehen verloren, wenn
//     der Code erneut generiert wird.
// </auto-generated>
//------------------------------------------------------------------------------

namespace _Root.NewTraceBigLineProblemPackage1
{
    using Emotive.Common.DataTypes;
    using System.Linq;
    using System.Xml.Linq;
    
    
    [Emotive.Common.DataTypes.ImportAttribute("")]
    public class Doc_NewDocument1
    {
        
        private static bool nh5vf1jjs0z;
        
        public static void Init()
        {
            nh5vf1jjs0z = false;
            System.Collections.Generic.List<string> tejwcbyx3au = new System.Collections.Generic.List<string>();
            Emotive.Otf.Runtime.Functions.CoreLib.DocumentReferenceCache("NewTraceBigLineProblemPackage1.NewDocument1", tejwcbyx3au);
            Emotive.Otf.Runtime.Functions.CoreLib.ProcedureCache("NewTraceBigLineProblemPackage1.NewDocument1.main", new Doc_NewDocument1.delegate_main(Doc_NewDocument1.proc_main), "NewDocument1", "NewTraceBigLineProblemPackage1", "TraceBigLineProblem", Emotive.Otf.Runtime.Functions.Visibility.PUBLIC, null);
        }
        
        private static void DisplayGlobalDeclarations()
        {
            if ((nh5vf1jjs0z == false))
            {
            }
            nh5vf1jjs0z = true;
        }
        
        public static void Dispose()
        {
        }
        
        [Emotive.Common.DataTypes.OtxElementAttribute(Emotive.Common.DataTypes.OtxElementTypes.Procedure, 0)]
        public static void proc_main()
        {
            DisplayGlobalDeclarations();
            Emotive.Otf.Runtime.Environment.ExecutionSection section_fijof41oxzn = new Emotive.Otf.Runtime.Environment.ExecutionSection("TraceBigLineProblem", "NewTraceBigLineProblemPackage1", "NewDocument1", "main");
            Emotive.Otf.Runtime.Variables.Variable<string> var_String1 = new Emotive.Otf.Runtime.Variables.Variable<string>(new Emotive.Otf.Model.Data.LocationReference("TraceBigLineProblem", "TraceBigLineProblem", "NewTraceBigLineProblemPackage1.NewDocument1", "main", "String1"), "", "String");
            Emotive.Otf.Runtime.Variables.Variable<long> var_Counter1 = new Emotive.Otf.Runtime.Variables.Variable<long>(new Emotive.Otf.Model.Data.LocationReference("TraceBigLineProblem", "TraceBigLineProblem", "NewTraceBigLineProblemPackage1.NewDocument1", "main", "Counter1"), 0L, "Integer");
            Emotive.Otf.Runtime.Environment.ThrowHelper.RegisterProcedure("NewTraceBigLineProblemPackage1.NewDocument1.main");
            System.Delegate procedureCall;
            var_String1.UpdateVariableTraceButSkipDefaultValue();
            var_Counter1.UpdateVariableTraceButSkipDefaultValue();
            string b0debyiydl4_EndNode = "";
            Emotive.Otf.Runtime.Project.ProjectManager.AddProject("TraceBigLineProblem", false);
            Emotive.Otf.Runtime.MVCISystem.RuntimeHelper.InitRuntimeForExecution(section_fijof41oxzn);
            // This variable is used as a divisor when the divisor in a divide is zero.
            int ZeroDivisor_kshl1lyvays = 0;
            Emotive.Otf.Runtime.Environment.RuntimeEntry.FireProcedureStarted("TraceBigLineProblem", "NewTraceBigLineProblemPackage1.NewDocument1.main");
            // Action - Assignment1 - Assignment_f11fb81888464367828ba32d9cc4d888
            if (Emotive.Otf.Runtime.Environment.RuntimeEnvironment.Instance.IsNotTerminated())
            {
                try
                {
                    Emotive.Otf.Runtime.Functions.LoggingLib.WriteOtxIdIfNeeded("TraceBigLineProblem@NewTraceBigLineProblemPackage1@NewDocument1@main", "Activität Assignment_f11fb81888464367828ba32d9cc4d888 (Assignment1) wird ausgefüh" +
                            "rt");
                    if (true)
                    {
                        var_String1.Value = "A";
                    }
                }
                catch (System.Exception Assignment_f11fb81888464367828ba32d9cc4d888_exception)
                {
                    Emotive.Otf.Runtime.Environment.ThrowHelper.Throw(Assignment_f11fb81888464367828ba32d9cc4d888_exception, "Assignment_f11fb81888464367828ba32d9cc4d888", "TraceBigLineProblem");
                }
            }
            // Loop - ForLoop1 - Loop_053619c45257480bb4f554a085de93a0
            if (Emotive.Otf.Runtime.Environment.RuntimeEnvironment.Instance.IsNotTerminated())
            {
                try
                {
                    Emotive.Otf.Runtime.Functions.LoggingLib.WriteOtxIdIfNeeded("TraceBigLineProblem@NewTraceBigLineProblemPackage1@NewDocument1@main", "Activität Loop_053619c45257480bb4f554a085de93a0 (ForLoop1) wird ausgeführt");
                    for (var_Counter1.Value = ((long)(0L)); ((var_Counter1.Value <= 1000L) 
                                && Emotive.Otf.Runtime.Environment.RuntimeEnvironment.Instance.IsNotTerminated()); var_Counter1.Value = (var_Counter1.Value + 1))
                    {
                        // Handler - Handler - Handler_51d742d8481a4d1abc2ae5f18a171c13
                        if (Emotive.Otf.Runtime.Environment.RuntimeEnvironment.Instance.IsNotTerminated())
                        {
                            try
                            {
                                Emotive.Otf.Runtime.Functions.LoggingLib.WriteOtxIdIfNeeded("TraceBigLineProblem@NewTraceBigLineProblemPackage1@NewDocument1@main", "Activität Handler_51d742d8481a4d1abc2ae5f18a171c13 (Handler) wird ausgeführt");
                                try
                                {
                                    // Action - Assignment2 - Assignment_599c671afeae45138266913ff179b315
                                    if (Emotive.Otf.Runtime.Environment.RuntimeEnvironment.Instance.IsNotTerminated())
                                    {
                                        try
                                        {
                                            Emotive.Otf.Runtime.Functions.LoggingLib.WriteOtxIdIfNeeded("TraceBigLineProblem@NewTraceBigLineProblemPackage1@NewDocument1@main", "Activität Assignment_599c671afeae45138266913ff179b315 (Assignment2) wird ausgefüh" +
                                                    "rt");
                                            if (true)
                                            {
                                                var_String1.Value = Emotive.Otf.Runtime.Functions.StringUtilLib.StringConcatenate(var_String1.Value, var_String1.Value);
                                            }
                                        }
                                        catch (System.Exception Assignment_599c671afeae45138266913ff179b315_exception)
                                        {
                                            Emotive.Otf.Runtime.Environment.ThrowHelper.Throw(Assignment_599c671afeae45138266913ff179b315_exception, "Assignment_599c671afeae45138266913ff179b315", "TraceBigLineProblem");
                                        }
                                    }
                                }
                                catch (Emotive.Otf.Model.Exception.Exception Handler_51d742d8481a4d1abc2ae5f18a171c13_exception)
                                {
                                    // Break - ForLoop1BreakActivity - Break_2f4e0600597a4925a84e5e37b846b521
                                    if (Emotive.Otf.Runtime.Environment.RuntimeEnvironment.Instance.IsNotTerminated())
                                    {
                                        Emotive.Otf.Runtime.Functions.LoggingLib.WriteOtxIdIfNeeded("TraceBigLineProblem@NewTraceBigLineProblemPackage1@NewDocument1@main", "Activität Break_2f4e0600597a4925a84e5e37b846b521 (ForLoop1BreakActivity) wird aus" +
                                                "geführt");
                                        goto ForLoop1_break;
                                    }
                                }
                            }
                            catch (System.Exception Handler_51d742d8481a4d1abc2ae5f18a171c13_exception)
                            {
                                Emotive.Otf.Runtime.Environment.ThrowHelper.Throw(Handler_51d742d8481a4d1abc2ae5f18a171c13_exception, "Handler_51d742d8481a4d1abc2ae5f18a171c13", "TraceBigLineProblem");
                            }
                        }
                    ForLoop1_continue:
;
                    }
                ForLoop1_break:
;
                }
                catch (System.Exception Loop_053619c45257480bb4f554a085de93a0_exception)
                {
                    Emotive.Otf.Runtime.Environment.ThrowHelper.Throw(Loop_053619c45257480bb4f554a085de93a0_exception, "Loop_053619c45257480bb4f554a085de93a0", "TraceBigLineProblem");
                }
            }
            // Action - ConfirmDialog1 - ConfirmDialog_7e161c36ca534f02b5ededaed3dc8cab
            if (Emotive.Otf.Runtime.Environment.RuntimeEnvironment.Instance.IsNotTerminated())
            {
                try
                {
                    Emotive.Otf.Runtime.Functions.LoggingLib.WriteOtxIdIfNeeded("TraceBigLineProblem@NewTraceBigLineProblemPackage1@NewDocument1@main", "Activität ConfirmDialog_7e161c36ca534f02b5ededaed3dc8cab (ConfirmDialog1) wird au" +
                            "sgeführt");
                    if (true)
                    {
                        Emotive.Otf.Runtime.Variables.Variable<Emotive.Otf.Model.Data.ConfirmationTypes> dummyVar_2acc7b89619d4200aeda3703e02db1a9 = new Emotive.Otf.Runtime.Variables.Variable<Emotive.Otf.Model.Data.ConfirmationTypes>(new Emotive.Otf.Model.Data.LocationReference("TraceBigLineProblem", "TraceBigLineProblem", "NewTraceBigLineProblemPackage1.NewDocument1", "main", "dummyVar_2acc7b89619d4200aeda3703e02db1a9"), Emotive.Otf.Model.Data.ConfirmationTypes.YES, "ConfirmationType");
                        Emotive.Otf.Runtime.Functions.HMILib.ConfirmDialog("", "Ready", null, dummyVar_2acc7b89619d4200aeda3703e02db1a9);
                    }
                }
                catch (System.Exception ConfirmDialog_7e161c36ca534f02b5ededaed3dc8cab_exception)
                {
                    Emotive.Otf.Runtime.Environment.ThrowHelper.Throw(ConfirmDialog_7e161c36ca534f02b5ededaed3dc8cab_exception, "ConfirmDialog_7e161c36ca534f02b5ededaed3dc8cab", "TraceBigLineProblem");
                }
            }
            Emotive.Otf.Runtime.Environment.ThrowHelper.RemoveProcedure("NewTraceBigLineProblemPackage1.NewDocument1.main");
            Emotive.Otf.Runtime.Project.ProjectManager.RemoveCurrentProject();
        }
        
        public delegate void delegate_main();
    }
}
