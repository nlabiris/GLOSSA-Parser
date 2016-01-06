using Antlr4.Runtime.Tree;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;

namespace Glossa {
    public class GLOSSAParseTreePrinter : GLOSSABaseListener {
        /// <summary>
        /// The stack with the rules that are being stored while traversing the parse tree.
        /// </summary>
        private readonly Stack<string> m_ruleStack = new Stack<string>();

        /// <summary>
        /// Every time we enter a rule we save that rule name which is used later to find the right path when we traverse the nodes.
        /// </summary>
        private string m_previousRule = string.Empty;

        /// <summary>
        /// A number that is used to differentiate rules with the same name.
        /// </summary>
        private int m_serialNumber = 0;

        /// <summary>
        /// <c>StreamWriter</c> object.
        /// </summary>
        private StreamWriter m_writer;

        public GLOSSAParseTreePrinter(string filename) {
            m_writer = new StreamWriter(filename);
        }

        /// <summary>
        /// Call GraphViz to parse the <c>DOT</c> file in order to create a graph as image.
        /// </summary>
        /// <param name="filename">Filename of <c>DOT</c> file.</param>
        /// <param name="imagename">Name of the image that contains the graph.</param>
        public void CallGraphViz(string filename, string imagename) {
            // Creating and starting DOT
            Process dot = new Process();
            string execute = "-Tpng " + filename + " -o " + imagename;
            ProcessStartInfo processInfoDot = new ProcessStartInfo("dot", execute);
            processInfoDot.UseShellExecute = false;
            processInfoDot.RedirectStandardOutput = true;
            dot.StartInfo = processInfoDot;
            dot.Start();
            dot.WaitForExit();
            dot.Close();
        }



        /*************************************************************************************************/
        /*************************************************************************************************/
        /*                                          ENTER METHODS                                        */
        /*************************************************************************************************/
        /*************************************************************************************************/

        public override void EnterFilestart(GLOSSAParser.FilestartContext context) {
            m_writer.WriteLine("digraph G {");

            // Print edge from the parent to the child
            if (m_ruleStack.Count != 0) {
                m_previousRule = m_ruleStack.Peek();
                m_writer.WriteLine("node [shape=box, style=\"rounded,filled\", color=red, fillcolor=khaki];");
                m_writer.WriteLine("\"{0}\" -> \"{1}\";", m_previousRule, "filestart_" + m_serialNumber);
            }

            m_ruleStack.Push("filestart_" + m_serialNumber);
            m_previousRule = "filestart_" + m_serialNumber;
        }

        public override void EnterProgramstart(GLOSSAParser.ProgramstartContext context) {
            m_serialNumber++;
            // Print edge from the parent to the child
            if (m_ruleStack.Count != 0) {
                m_previousRule = m_ruleStack.Peek();
                m_writer.WriteLine("node [shape=box, style=\"rounded,filled\", color=red, fillcolor=khaki];");
                m_writer.WriteLine("\"{0}\" -> \"{1}\";", m_previousRule, "programstart_" + m_serialNumber);
            }

            m_ruleStack.Push("programstart_" + m_serialNumber);
            m_previousRule = "programstart_" + m_serialNumber;
        }

        public override void EnterStmtlist(GLOSSAParser.StmtlistContext context) {
            m_serialNumber++;
            // Print edge from the parent to the child
            if (m_ruleStack.Count != 0) {
                m_previousRule = m_ruleStack.Peek();
                m_writer.WriteLine("node [shape=box, style=\"rounded,filled\", color=red, fillcolor=khaki];");
                m_writer.WriteLine("\"{0}\" -> \"{1}\";", m_previousRule, "stmtlist_" + m_serialNumber);
            }

            m_ruleStack.Push("stmtlist_" + m_serialNumber);
            m_previousRule = "stmtlist_" + m_serialNumber;
        }

        public override void EnterStat_expr(GLOSSAParser.Stat_exprContext context) {
            m_serialNumber++;
            // Print edge from the parent to the child
            if (m_ruleStack.Count != 0) {
                m_previousRule = m_ruleStack.Peek();
                m_writer.WriteLine("node [shape=box, style=\"rounded,filled\", color=red, fillcolor=khaki];");
                m_writer.WriteLine("\"{0}\" -> \"{1}\";", m_previousRule, "stat_expr_" + m_serialNumber);
            }

            m_ruleStack.Push("stat_expr_" + m_serialNumber);
            m_previousRule = "stat_expr_" + m_serialNumber;
        }

        public override void EnterStat_assignment(GLOSSAParser.Stat_assignmentContext context) {
            m_serialNumber++;
            // Print edge from the parent to the child
            if (m_ruleStack.Count != 0) {
                m_previousRule = m_ruleStack.Peek();
                m_writer.WriteLine("node [shape=box, style=\"rounded,filled\", color=red, fillcolor=khaki];");
                m_writer.WriteLine("\"{0}\" -> \"{1}\";", m_previousRule, "stat_assignment_" + m_serialNumber);
            }

            m_ruleStack.Push("stat_assignment_" + m_serialNumber);
            m_previousRule = "stat_assignment_" + m_serialNumber;
        }

        public override void EnterStat_ioexpr(GLOSSAParser.Stat_ioexprContext context) {
            m_serialNumber++;
            // Print edge from the parent to the child
            if (m_ruleStack.Count != 0) {
                m_previousRule = m_ruleStack.Peek();
                m_writer.WriteLine("node [shape=box, style=\"rounded,filled\", color=red, fillcolor=khaki];");
                m_writer.WriteLine("\"{0}\" -> \"{1}\";", m_previousRule, "stat_ioexpr_" + m_serialNumber);
            }

            m_ruleStack.Push("stat_ioexpr_" + m_serialNumber);
            m_previousRule = "stat_ioexpr_" + m_serialNumber;
        }

        public override void EnterStat_ifctrl(GLOSSAParser.Stat_ifctrlContext context) {
            m_serialNumber++;
            // Print edge from the parent to the child
            if (m_ruleStack.Count != 0) {
                m_previousRule = m_ruleStack.Peek();
                m_writer.WriteLine("node [shape=box, style=\"rounded,filled\", color=red, fillcolor=khaki];");
                m_writer.WriteLine("\"{0}\" -> \"{1}\";", m_previousRule, "stat_ifctrl_" + m_serialNumber);
            }

            m_ruleStack.Push("stat_ifctrl_" + m_serialNumber);
            m_previousRule = "stat_ifctrl_" + m_serialNumber;
        }

        public override void EnterStat_dowhile(GLOSSAParser.Stat_dowhileContext context) {
            m_serialNumber++;
            // Print edge from the parent to the child
            if (m_ruleStack.Count != 0) {
                m_previousRule = m_ruleStack.Peek();
                m_writer.WriteLine("node [shape=box, style=\"rounded,filled\", color=red, fillcolor=khaki];");
                m_writer.WriteLine("\"{0}\" -> \"{1}\";", m_previousRule, "stat_dowhile_" + m_serialNumber);
            }

            m_ruleStack.Push("stat_dowhile_" + m_serialNumber);
            m_previousRule = "stat_dowhile_" + m_serialNumber;
        }

        public override void EnterStat_while(GLOSSAParser.Stat_whileContext context) {
            m_serialNumber++;
            // Print edge from the parent to the child
            if (m_ruleStack.Count != 0) {
                m_previousRule = m_ruleStack.Peek();
                m_writer.WriteLine("node [shape=box, style=\"rounded,filled\", color=red, fillcolor=khaki];");
                m_writer.WriteLine("\"{0}\" -> \"{1}\";", m_previousRule, "stat_while_" + m_serialNumber);
            }

            m_ruleStack.Push("stat_while_" + m_serialNumber);
            m_previousRule = "stat_while_" + m_serialNumber;
        }

        public override void EnterStat_switch(GLOSSAParser.Stat_switchContext context) {
            m_serialNumber++;
            // Print edge from the parent to the child
            if (m_ruleStack.Count != 0) {
                m_previousRule = m_ruleStack.Peek();
                m_writer.WriteLine("node [shape=box, style=\"rounded,filled\", color=red, fillcolor=khaki];");
                m_writer.WriteLine("\"{0}\" -> \"{1}\";", m_previousRule, "stat_switch_" + m_serialNumber);
            }

            m_ruleStack.Push("stat_switch_" + m_serialNumber);
            m_previousRule = "stat_switch_" + m_serialNumber;
        }

        public override void EnterVardecl(GLOSSAParser.VardeclContext context) {
            m_serialNumber++;
            // Print edge from the parent to the child
            if (m_ruleStack.Count != 0) {
                m_previousRule = m_ruleStack.Peek();
                m_writer.WriteLine("node [shape=box, style=\"rounded,filled\", color=red, fillcolor=khaki];");
                m_writer.WriteLine("\"{0}\" -> \"{1}\";", m_previousRule, "vardecl_" + m_serialNumber);
            }

            m_ruleStack.Push("vardecl_" + m_serialNumber);
            m_previousRule = "vardecl_" + m_serialNumber;
        }

        public override void EnterConstdecl(GLOSSAParser.ConstdeclContext context) {
            m_serialNumber++;
            // Print edge from the parent to the child
            if (m_ruleStack.Count != 0) {
                m_previousRule = m_ruleStack.Peek();
                m_writer.WriteLine("node [shape=box, style=\"rounded,filled\", color=red, fillcolor=khaki];");
                m_writer.WriteLine("\"{0}\" -> \"{1}\";", m_previousRule, "constdecl_" + m_serialNumber);
            }

            m_ruleStack.Push("constdecl_" + m_serialNumber);
            m_previousRule = "constdecl_" + m_serialNumber;
        }

        public override void EnterFuncdef1(GLOSSAParser.Funcdef1Context context) {
            m_serialNumber++;
            // Print edge from the parent to the child
            if (m_ruleStack.Count != 0) {
                m_previousRule = m_ruleStack.Peek();
                m_writer.WriteLine("node [shape=box, style=\"rounded,filled\", color=red, fillcolor=khaki];");
                m_writer.WriteLine("\"{0}\" -> \"{1}\";", m_previousRule, "funcdef1_" + m_serialNumber);
            }

            m_ruleStack.Push("funcdef1_" + m_serialNumber);
            m_previousRule = "funcdef1_" + m_serialNumber;
        }

        public override void EnterFuncdef2(GLOSSAParser.Funcdef2Context context) {
            m_serialNumber++;
            // Print edge from the parent to the child
            if (m_ruleStack.Count != 0) {
                m_previousRule = m_ruleStack.Peek();
                m_writer.WriteLine("node [shape=box, style=\"rounded,filled\", color=red, fillcolor=khaki];");
                m_writer.WriteLine("\"{0}\" -> \"{1}\";", m_previousRule, "funcdef2_" + m_serialNumber);
            }

            m_ruleStack.Push("funcdef2_" + m_serialNumber);
            m_previousRule = "funcdef2_" + m_serialNumber;
        }

        public override void EnterProcdef1(GLOSSAParser.Procdef1Context context) {
            m_serialNumber++;
            // Print edge from the parent to the child
            if (m_ruleStack.Count != 0) {
                m_previousRule = m_ruleStack.Peek();
                m_writer.WriteLine("node [shape=box, style=\"rounded,filled\", color=red, fillcolor=khaki];");
                m_writer.WriteLine("\"{0}\" -> \"{1}\";", m_previousRule, "procdef1_" + m_serialNumber);
            }

            m_ruleStack.Push("procdef1_" + m_serialNumber);
            m_previousRule = "procdef1_" + m_serialNumber;
        }

        public override void EnterProcdef2(GLOSSAParser.Procdef2Context context) {
            m_serialNumber++;
            // Print edge from the parent to the child
            if (m_ruleStack.Count != 0) {
                m_previousRule = m_ruleStack.Peek();
                m_writer.WriteLine("node [shape=box, style=\"rounded,filled\", color=red, fillcolor=khaki];");
                m_writer.WriteLine("\"{0}\" -> \"{1}\";", m_previousRule, "procdef2_" + m_serialNumber);
            }

            m_ruleStack.Push("procdef2_" + m_serialNumber);
            m_previousRule = "procdef2_" + m_serialNumber;
        }

        public override void EnterVardecl_alt1(GLOSSAParser.Vardecl_alt1Context context) {
            m_serialNumber++;
            // Print edge from the parent to the child
            if (m_ruleStack.Count != 0) {
                m_previousRule = m_ruleStack.Peek();
                m_writer.WriteLine("node [shape=box, style=\"rounded,filled\", color=red, fillcolor=khaki];");
                m_writer.WriteLine("\"{0}\" -> \"{1}\";", m_previousRule, "vardecl_alt1_" + m_serialNumber);
            }

            m_ruleStack.Push("vardecl_alt1_" + m_serialNumber);
            m_previousRule = "vardecl_alt1_" + m_serialNumber;
        }

        public override void EnterVardecl_alt2(GLOSSAParser.Vardecl_alt2Context context) {
            m_serialNumber++;
            // Print edge from the parent to the child
            if (m_ruleStack.Count != 0) {
                m_previousRule = m_ruleStack.Peek();
                m_writer.WriteLine("node [shape=box, style=\"rounded,filled\", color=red, fillcolor=khaki];");
                m_writer.WriteLine("\"{0}\" -> \"{1}\";", m_previousRule, "vardecl_alt2_" + m_serialNumber);
            }

            m_ruleStack.Push("vardecl_alt2_" + m_serialNumber);
            m_previousRule = "vardecl_alt2_" + m_serialNumber;
        }

        public override void EnterConstdecl_alt1(GLOSSAParser.Constdecl_alt1Context context) {
            m_serialNumber++;
            // Print edge from the parent to the child
            if (m_ruleStack.Count != 0) {
                m_previousRule = m_ruleStack.Peek();
                m_writer.WriteLine("node [shape=box, style=\"rounded,filled\", color=red, fillcolor=khaki];");
                m_writer.WriteLine("\"{0}\" -> \"{1}\";", m_previousRule, "constdecl_alt1_" + m_serialNumber);
            }

            m_ruleStack.Push("constdecl_alt1_" + m_serialNumber);
            m_previousRule = "constdecl_alt1_" + m_serialNumber;
        }

        public override void EnterIfctrl(GLOSSAParser.IfctrlContext context) {
            m_serialNumber++;
            // Print edge from the parent to the child
            if (m_ruleStack.Count != 0) {
                m_previousRule = m_ruleStack.Peek();
                m_writer.WriteLine("node [shape=box, style=\"rounded,filled\", color=red, fillcolor=khaki];");
                m_writer.WriteLine("\"{0}\" -> \"{1}\";", m_previousRule, "ifctrl_" + m_serialNumber);
            }

            m_ruleStack.Push("ifctrl_" + m_serialNumber);
            m_previousRule = "ifctrl_" + m_serialNumber;
        }

        public override void EnterElseifctrl(GLOSSAParser.ElseifctrlContext context) {
            m_serialNumber++;
            // Print edge from the parent to the child
            if (m_ruleStack.Count != 0) {
                m_previousRule = m_ruleStack.Peek();
                m_writer.WriteLine("node [shape=box, style=\"rounded,filled\", color=red, fillcolor=khaki];");
                m_writer.WriteLine("\"{0}\" -> \"{1}\";", m_previousRule, "elseifctrl_" + m_serialNumber);
            }

            m_ruleStack.Push("elseifctrl_" + m_serialNumber);
            m_previousRule = "elseifctrl_" + m_serialNumber;
        }

        public override void EnterElsectrl(GLOSSAParser.ElsectrlContext context) {
            m_serialNumber++;
            // Print edge from the parent to the child
            if (m_ruleStack.Count != 0) {
                m_previousRule = m_ruleStack.Peek();
                m_writer.WriteLine("node [shape=box, style=\"rounded,filled\", color=red, fillcolor=khaki];");
                m_writer.WriteLine("\"{0}\" -> \"{1}\";", m_previousRule, "elsectrl_" + m_serialNumber);
            }

            m_ruleStack.Push("elsectrl_" + m_serialNumber);
            m_previousRule = "elsectrl_" + m_serialNumber;
        }

        public override void EnterDowhilectrl(GLOSSAParser.DowhilectrlContext context) {
            m_serialNumber++;
            // Print edge from the parent to the child
            if (m_ruleStack.Count != 0) {
                m_previousRule = m_ruleStack.Peek();
                m_writer.WriteLine("node [shape=box, style=\"rounded,filled\", color=red, fillcolor=khaki];");
                m_writer.WriteLine("\"{0}\" -> \"{1}\";", m_previousRule, "dowhilectrl_" + m_serialNumber);
            }

            m_ruleStack.Push("dowhilectrl_" + m_serialNumber);
            m_previousRule = "dowhilectrl_" + m_serialNumber;
        }

        public override void EnterWhilectrl(GLOSSAParser.WhilectrlContext context) {
            m_serialNumber++;
            // Print edge from the parent to the child
            if (m_ruleStack.Count != 0) {
                m_previousRule = m_ruleStack.Peek();
                m_writer.WriteLine("node [shape=box, style=\"rounded,filled\", color=red, fillcolor=khaki];");
                m_writer.WriteLine("\"{0}\" -> \"{1}\";", m_previousRule, "whilectrl_" + m_serialNumber);
            }

            m_ruleStack.Push("whilectrl_" + m_serialNumber);
            m_previousRule = "whilectrl_" + m_serialNumber;
        }

        public override void EnterForctrl(GLOSSAParser.ForctrlContext context) {
            m_serialNumber++;
            // Print edge from the parent to the child
            if (m_ruleStack.Count != 0) {
                m_previousRule = m_ruleStack.Peek();
                m_writer.WriteLine("node [shape=box, style=\"rounded,filled\", color=red, fillcolor=khaki];");
                m_writer.WriteLine("\"{0}\" -> \"{1}\";", m_previousRule, "forctrl_" + m_serialNumber);
            }

            m_ruleStack.Push("forctrl_" + m_serialNumber);
            m_previousRule = "forctrl_" + m_serialNumber;
        }

        public override void EnterSwitchctrl(GLOSSAParser.SwitchctrlContext context) {
            m_serialNumber++;
            // Print edge from the parent to the child
            if (m_ruleStack.Count != 0) {
                m_previousRule = m_ruleStack.Peek();
                m_writer.WriteLine("node [shape=box, style=\"rounded,filled\", color=red, fillcolor=khaki];");
                m_writer.WriteLine("\"{0}\" -> \"{1}\";", m_previousRule, "switchctrl_" + m_serialNumber);
            }

            m_ruleStack.Push("switchctrl_" + m_serialNumber);
            m_previousRule = "switchctrl_" + m_serialNumber;
        }

        public override void EnterCasectrl(GLOSSAParser.CasectrlContext context) {
            m_serialNumber++;
            // Print edge from the parent to the child
            if (m_ruleStack.Count != 0) {
                m_previousRule = m_ruleStack.Peek();
                m_writer.WriteLine("node [shape=box, style=\"rounded,filled\", color=red, fillcolor=khaki];");
                m_writer.WriteLine("\"{0}\" -> \"{1}\";", m_previousRule, "casectrl_" + m_serialNumber);
            }

            m_ruleStack.Push("casectrl_" + m_serialNumber);
            m_previousRule = "casectrl_" + m_serialNumber;
        }

        public override void EnterOtherwisectrl(GLOSSAParser.OtherwisectrlContext context) {
            m_serialNumber++;
            // Print edge from the parent to the child
            if (m_ruleStack.Count != 0) {
                m_previousRule = m_ruleStack.Peek();
                m_writer.WriteLine("node [shape=box, style=\"rounded,filled\", color=red, fillcolor=khaki];");
                m_writer.WriteLine("\"{0}\" -> \"{1}\";", m_previousRule, "otherwise_" + m_serialNumber);
            }

            m_ruleStack.Push("otherwise_" + m_serialNumber);
            m_previousRule = "otherwise_" + m_serialNumber;
        }

        public override void EnterFunargs(GLOSSAParser.FunargsContext context) {
            m_serialNumber++;
            // Print edge from the parent to the child
            if (m_ruleStack.Count != 0) {
                m_previousRule = m_ruleStack.Peek();
                m_writer.WriteLine("node [shape=box, style=\"rounded,filled\", color=red, fillcolor=khaki];");
                m_writer.WriteLine("\"{0}\" -> \"{1}\";", m_previousRule, "funargs_" + m_serialNumber);
            }

            m_ruleStack.Push("funargs_" + m_serialNumber);
            m_previousRule = "funargs_" + m_serialNumber;
        }

        public override void EnterAssign(GLOSSAParser.AssignContext context) {
            m_serialNumber++;
            // Print edge from the parent to the child
            if (m_ruleStack.Count != 0) {
                m_previousRule = m_ruleStack.Peek();
                m_writer.WriteLine("node [shape=box, style=\"rounded,filled\", color=red, fillcolor=khaki];");
                m_writer.WriteLine("\"{0}\" -> \"{1}\";", m_previousRule, "assign_" + m_serialNumber);
            }

            m_ruleStack.Push("assign_" + m_serialNumber);
            m_previousRule = "assign_" + m_serialNumber;
        }

        public override void EnterExpr_paren(GLOSSAParser.Expr_parenContext context) {
            m_serialNumber++;
            // Print edge from the parent to the child
            if (m_ruleStack.Count != 0) {
                m_previousRule = m_ruleStack.Peek();
                m_writer.WriteLine("node [shape=box, style=\"rounded,filled\", color=red, fillcolor=khaki];");
                m_writer.WriteLine("\"{0}\" -> \"{1}\";", m_previousRule, "expr_paren_" + m_serialNumber);
            }

            m_ruleStack.Push("expr_paren_" + m_serialNumber);
            m_previousRule = "expr_paren_" + m_serialNumber;
        }

        public override void EnterExpr_power(GLOSSAParser.Expr_powerContext context) {
            m_serialNumber++;
            // Print edge from the parent to the child
            if (m_ruleStack.Count != 0) {
                m_previousRule = m_ruleStack.Peek();
                m_writer.WriteLine("node [shape=box, style=\"rounded,filled\", color=red, fillcolor=khaki];");
                m_writer.WriteLine("\"{0}\" -> \"{1}\";", m_previousRule, "expr_power_" + m_serialNumber);
            }

            m_ruleStack.Push("expr_power_" + m_serialNumber);
            m_previousRule = "expr_power_" + m_serialNumber;
        }

        public override void EnterExpr_unary(GLOSSAParser.Expr_unaryContext context) {
            if (context.op.Type == GLOSSAParser.PLUS) {
                m_serialNumber++;
                // Print edge from the parent to the child
                if (m_ruleStack.Count != 0) {
                    m_previousRule = m_ruleStack.Peek();
                    m_writer.WriteLine("node [shape=box, style=\"rounded,filled\", color=red, fillcolor=khaki];");
                    m_writer.WriteLine("\"{0}\" -> \"{1}\";", m_previousRule, "exprunary_plus_" + m_serialNumber);
                }

                m_ruleStack.Push("exprunary_plus_" + m_serialNumber);
                m_previousRule = "exprunary_plus_" + m_serialNumber;
            } else if (context.op.Type == GLOSSAParser.MINUS) {
                m_serialNumber++;
                // Print edge from the parent to the child
                if (m_ruleStack.Count != 0) {
                    m_previousRule = m_ruleStack.Peek();
                    m_writer.WriteLine("node [shape=box, style=\"rounded,filled\", color=red, fillcolor=khaki];");
                    m_writer.WriteLine("\"{0}\" -> \"{1}\";", m_previousRule, "exprunary_minus_" + m_serialNumber);
                }

                m_ruleStack.Push("exprunary_minus_" + m_serialNumber);
                m_previousRule = "exprunary_minus_" + m_serialNumber;
            } else if (context.op.Type == GLOSSAParser.OXI) {
                m_serialNumber++;
                // Print edge from the parent to the child
                if (m_ruleStack.Count != 0) {
                    m_previousRule = m_ruleStack.Peek();
                    m_writer.WriteLine("node [shape=box, style=\"rounded,filled\", color=red, fillcolor=khaki];");
                    m_writer.WriteLine("\"{0}\" -> \"{1}\";", m_previousRule, "exprunary_oxi_" + m_serialNumber);
                }

                m_ruleStack.Push("exprunary_oxi_" + m_serialNumber);
                m_previousRule = "exprunary_oxi_" + m_serialNumber;
            }
        }

        public override void EnterExpr_muldiv(GLOSSAParser.Expr_muldivContext context) {
            if (context.op.Type == GLOSSAParser.MUL) {
                m_serialNumber++;
                // Print edge from the parent to the child
                if (m_ruleStack.Count != 0) {
                    m_previousRule = m_ruleStack.Peek();
                    m_writer.WriteLine("node [shape=box, style=\"rounded,filled\", color=red, fillcolor=khaki];");
                    m_writer.WriteLine("\"{0}\" -> \"{1}\";", m_previousRule, "expr_mul_" + m_serialNumber);
                }

                m_ruleStack.Push("expr_mul_" + m_serialNumber);
                m_previousRule = "expr_mul_" + m_serialNumber;
            } else if (context.op.Type == GLOSSAParser.DIV) {
                m_serialNumber++;
                // Print edge from the parent to the child
                if (m_ruleStack.Count != 0) {
                    m_previousRule = m_ruleStack.Peek();
                    m_writer.WriteLine("node [shape=box, style=\"rounded,filled\", color=red, fillcolor=khaki];");
                    m_writer.WriteLine("\"{0}\" -> \"{1}\";", m_previousRule, "expr_div_" + m_serialNumber);
                }

                m_ruleStack.Push("expr_div_" + m_serialNumber);
                m_previousRule = "expr_div_" + m_serialNumber;
            }
        }

        public override void EnterExpr_plusminus(GLOSSAParser.Expr_plusminusContext context) {
            if (context.op.Type == GLOSSAParser.PLUS) {
                m_serialNumber++;
                // Print edge from the parent to the child
                if (m_ruleStack.Count != 0) {
                    m_previousRule = m_ruleStack.Peek();
                    m_writer.WriteLine("node [shape=box, style=\"rounded,filled\", color=red, fillcolor=khaki];");
                    m_writer.WriteLine("\"{0}\" -> \"{1}\";", m_previousRule, "expr_plus_" + m_serialNumber);
                }

                m_ruleStack.Push("expr_plus_" + m_serialNumber);
                m_previousRule = "expr_plus_" + m_serialNumber;
            } else if (context.op.Type == GLOSSAParser.MINUS) {
                m_serialNumber++;
                // Print edge from the parent to the child
                if (m_ruleStack.Count != 0) {
                    m_previousRule = m_ruleStack.Peek();
                    m_writer.WriteLine("node [shape=box, style=\"rounded,filled\", color=red, fillcolor=khaki];");
                    m_writer.WriteLine("\"{0}\" -> \"{1}\";", m_previousRule, "expr_minus_" + m_serialNumber);
                }

                m_ruleStack.Push("expr_minus_" + m_serialNumber);
                m_previousRule = "expr_minus_" + m_serialNumber;
            }
        }

        public override void EnterExpr_compare(GLOSSAParser.Expr_compareContext context) {
            if (context.op.Type == GLOSSAParser.EQUALS) {
                m_serialNumber++;
                // Print edge from the parent to the child
                if (m_ruleStack.Count != 0) {
                    m_previousRule = m_ruleStack.Peek();
                    m_writer.WriteLine("node [shape=box, style=\"rounded,filled\", color=red, fillcolor=khaki];");
                    m_writer.WriteLine("\"{0}\" -> \"{1}\";", m_previousRule, "expr_equals_" + m_serialNumber);
                }

                m_ruleStack.Push("expr_equals_" + m_serialNumber);
                m_previousRule = "expr_equals_" + m_serialNumber;
            } else if (context.op.Type == GLOSSAParser.NOTEQUALS) {
                m_serialNumber++;
                // Print edge from the parent to the child
                if (m_ruleStack.Count != 0) {
                    m_previousRule = m_ruleStack.Peek();
                    m_writer.WriteLine("node [shape=box, style=\"rounded,filled\", color=red, fillcolor=khaki];");
                    m_writer.WriteLine("\"{0}\" -> \"{1}\";", m_previousRule, "expr_notequals_" + m_serialNumber);
                }

                m_ruleStack.Push("expr_notequals_" + m_serialNumber);
                m_previousRule = "expr_notequals_" + m_serialNumber;
            } else if (context.op.Type == GLOSSAParser.LT) {
                m_serialNumber++;
                // Print edge from the parent to the child
                if (m_ruleStack.Count != 0) {
                    m_previousRule = m_ruleStack.Peek();
                    m_writer.WriteLine("node [shape=box, style=\"rounded,filled\", color=red, fillcolor=khaki];");
                    m_writer.WriteLine("\"{0}\" -> \"{1}\";", m_previousRule, "expr_lt_" + m_serialNumber);
                }

                m_ruleStack.Push("expr_lt_" + m_serialNumber);
                m_previousRule = "expr_lt_" + m_serialNumber;
            } else if (context.op.Type == GLOSSAParser.GT) {
                m_serialNumber++;
                // Print edge from the parent to the child
                if (m_ruleStack.Count != 0) {
                    m_previousRule = m_ruleStack.Peek();
                    m_writer.WriteLine("node [shape=box, style=\"rounded,filled\", color=red, fillcolor=khaki];");
                    m_writer.WriteLine("\"{0}\" -> \"{1}\";", m_previousRule, "expr_gt_" + m_serialNumber);
                }

                m_ruleStack.Push("expr_gt_" + m_serialNumber);
                m_previousRule = "expr_gt_" + m_serialNumber;
            } else if (context.op.Type == GLOSSAParser.LE) {
                m_serialNumber++;
                // Print edge from the parent to the child
                if (m_ruleStack.Count != 0) {
                    m_previousRule = m_ruleStack.Peek();
                    m_writer.WriteLine("node [shape=box, style=\"rounded,filled\", color=red, fillcolor=khaki];");
                    m_writer.WriteLine("\"{0}\" -> \"{1}\";", m_previousRule, "expr_le_" + m_serialNumber);
                }

                m_ruleStack.Push("expr_le_" + m_serialNumber);
                m_previousRule = "expr_le_" + m_serialNumber;
            } else if (context.op.Type == GLOSSAParser.GE) {
                m_serialNumber++;
                // Print edge from the parent to the child
                if (m_ruleStack.Count != 0) {
                    m_previousRule = m_ruleStack.Peek();
                    m_writer.WriteLine("node [shape=box, style=\"rounded,filled\", color=red, fillcolor=khaki];");
                    m_writer.WriteLine("\"{0}\" -> \"{1}\";", m_previousRule, "expr_ge_" + m_serialNumber);
                }

                m_ruleStack.Push("expr_ge_" + m_serialNumber);
                m_previousRule = "expr_ge_" + m_serialNumber;
            }
        }

        public override void EnterExpr_funcproccall(GLOSSAParser.Expr_funcproccallContext context) {
            m_serialNumber++;
            // Print edge from the parent to the child
            if (m_ruleStack.Count != 0) {
                m_previousRule = m_ruleStack.Peek();
                m_writer.WriteLine("node [shape=box, style=\"rounded,filled\", color=red, fillcolor=khaki];");
                m_writer.WriteLine("\"{0}\" -> \"{1}\";", m_previousRule, "expr_funcproccall_" + m_serialNumber);
            }

            m_ruleStack.Push("expr_funcproccall_" + m_serialNumber);
            m_previousRule = "expr_funcproccall_" + m_serialNumber;
        }

        public override void EnterExpr_expressionprimitives(GLOSSAParser.Expr_expressionprimitivesContext context) {
            m_serialNumber++;
            // Print edge from the parent to the child
            if (m_ruleStack.Count != 0) {
                m_previousRule = m_ruleStack.Peek();
                m_writer.WriteLine("node [shape=box, style=\"rounded,filled\", color=red, fillcolor=khaki];");
                m_writer.WriteLine("\"{0}\" -> \"{1}\";", m_previousRule, "expr_expressionprimitives_" + m_serialNumber);
            }

            m_ruleStack.Push("expr_expressionprimitives_" + m_serialNumber);
            m_previousRule = "expr_expressionprimitives_" + m_serialNumber;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="node"></param>
        public override void VisitTerminal(ITerminalNode node) {
            if (node.Symbol.Type == GLOSSAParser.PROGRAMMA) {
                m_serialNumber++;
                if (m_ruleStack.Count != 0) {
                    m_previousRule = m_ruleStack.Peek();
                    m_writer.WriteLine("node [fillcolor=palegreen];");
                    m_writer.WriteLine("\"{0}\" -> \"{1}\";", m_previousRule, "PROGRAMMA_s" + m_serialNumber);
                }
            }

            if (node.Symbol.Type == GLOSSAParser.ARXH) {
                m_serialNumber++;
                if (m_ruleStack.Count != 0) {
                    m_previousRule = m_ruleStack.Peek();
                    m_writer.WriteLine("node [fillcolor=palegreen];");
                    m_writer.WriteLine("\"{0}\" -> \"{1}\";", m_previousRule, "ARXH_s" + m_serialNumber);
                }
            }

            if (node.Symbol.Type == GLOSSAParser.TELOS_PROGRAMMATOS) {
                m_serialNumber++;
                if (m_ruleStack.Count != 0) {
                    m_previousRule = m_ruleStack.Peek();
                    m_writer.WriteLine("node [fillcolor=palegreen];");
                    m_writer.WriteLine("\"{0}\" -> \"{1}\";", m_previousRule, "TELOS_PROGRAMMATOS_s" + m_serialNumber);
                }
            }

            if (node.Symbol.Type == GLOSSAParser.SYNARTHSH) {
                m_serialNumber++;
                if (m_ruleStack.Count != 0) {
                    m_previousRule = m_ruleStack.Peek();
                    m_writer.WriteLine("node [fillcolor=palegreen];");
                    m_writer.WriteLine("\"{0}\" -> \"{1}\";", m_previousRule, "SYNARTHSH_s" + m_serialNumber);
                }
            }

            if (node.Symbol.Type == GLOSSAParser.TELOS_SYNARTHSHS) {
                m_serialNumber++;
                if (m_ruleStack.Count != 0) {
                    m_previousRule = m_ruleStack.Peek();
                    m_writer.WriteLine("node [fillcolor=palegreen];");
                    m_writer.WriteLine("\"{0}\" -> \"{1}\";", m_previousRule, "TELOS_SYNARTHSHS_s" + m_serialNumber);
                }
            }

            if (node.Symbol.Type == GLOSSAParser.DIADIKASIA) {
                m_serialNumber++;
                if (m_ruleStack.Count != 0) {
                    m_previousRule = m_ruleStack.Peek();
                    m_writer.WriteLine("node [fillcolor=palegreen];");
                    m_writer.WriteLine("\"{0}\" -> \"{1}\";", m_previousRule, "DIADIKASIA_s" + m_serialNumber);
                }
            }

            if (node.Symbol.Type == GLOSSAParser.TELOS_DIADIKASIAS) {
                m_serialNumber++;
                if (m_ruleStack.Count != 0) {
                    m_previousRule = m_ruleStack.Peek();
                    m_writer.WriteLine("node [fillcolor=palegreen];");
                    m_writer.WriteLine("\"{0}\" -> \"{1}\";", m_previousRule, "TELOS_DIADIKASIAS_s" + m_serialNumber);
                }
            }

            if (node.Symbol.Type == GLOSSAParser.METABLHTES) {
                m_serialNumber++;
                if (m_ruleStack.Count != 0) {
                    m_previousRule = m_ruleStack.Peek();
                    m_writer.WriteLine("node [fillcolor=palegreen];");
                    m_writer.WriteLine("\"{0}\" -> \"{1}\";", m_previousRule, "METABLHTES_s" + m_serialNumber);
                }
            }

            if (node.Symbol.Type == GLOSSAParser.STATHERES) {
                m_serialNumber++;
                if (m_ruleStack.Count != 0) {
                    m_previousRule = m_ruleStack.Peek();
                    m_writer.WriteLine("node [fillcolor=palegreen];");
                    m_writer.WriteLine("\"{0}\" -> \"{1}\";", m_previousRule, "STATHERES_s" + m_serialNumber);
                }
            }

            if (node.Symbol.Type == GLOSSAParser.AN) {
                m_serialNumber++;
                if (m_ruleStack.Count != 0) {
                    m_previousRule = m_ruleStack.Peek();
                    m_writer.WriteLine("node [fillcolor=palegreen];");
                    m_writer.WriteLine("\"{0}\" -> \"{1}\";", m_previousRule, "AN_s" + m_serialNumber);
                }
            }

            if (node.Symbol.Type == GLOSSAParser.TOTE) {
                m_serialNumber++;
                if (m_ruleStack.Count != 0) {
                    m_previousRule = m_ruleStack.Peek();
                    m_writer.WriteLine("node [fillcolor=palegreen];");
                    m_writer.WriteLine("\"{0}\" -> \"{1}\";", m_previousRule, "TOTE_s" + m_serialNumber);
                }
            }

            if (node.Symbol.Type == GLOSSAParser.TELOS_AN) {
                m_serialNumber++;
                if (m_ruleStack.Count != 0) {
                    m_previousRule = m_ruleStack.Peek();
                    m_writer.WriteLine("node [fillcolor=palegreen];");
                    m_writer.WriteLine("\"{0}\" -> \"{1}\";", m_previousRule, "TELOS_AN_s" + m_serialNumber);
                }
            }

            if (node.Symbol.Type == GLOSSAParser.ALLIOS_AN) {
                m_serialNumber++;
                if (m_ruleStack.Count != 0) {
                    m_previousRule = m_ruleStack.Peek();
                    m_writer.WriteLine("node [fillcolor=palegreen];");
                    m_writer.WriteLine("\"{0}\" -> \"{1}\";", m_previousRule, "ALLIOS_AN_s" + m_serialNumber);
                }
            }

            if (node.Symbol.Type == GLOSSAParser.ALLIOS) {
                m_serialNumber++;
                if (m_ruleStack.Count != 0) {
                    m_previousRule = m_ruleStack.Peek();
                    m_writer.WriteLine("node [fillcolor=palegreen];");
                    m_writer.WriteLine("\"{0}\" -> \"{1}\";", m_previousRule, "ALLIOS_s" + m_serialNumber);
                }
            }

            if (node.Symbol.Type == GLOSSAParser.AKERAIES) {
                m_serialNumber++;
                if (m_ruleStack.Count != 0) {
                    m_previousRule = m_ruleStack.Peek();
                    m_writer.WriteLine("node [fillcolor=palegreen];");
                    m_writer.WriteLine("\"{0}\" -> \"{1}\";", m_previousRule, "AKERAIES_s" + m_serialNumber);
                }
            }

            if (node.Symbol.Type == GLOSSAParser.PRAGMATIKES) {
                m_serialNumber++;
                if (m_ruleStack.Count != 0) {
                    m_previousRule = m_ruleStack.Peek();
                    m_writer.WriteLine("node [fillcolor=palegreen];");
                    m_writer.WriteLine("\"{0}\" -> \"{1}\";", m_previousRule, "PRAGMATIKES_s" + m_serialNumber);
                }
            }

            if (node.Symbol.Type == GLOSSAParser.XARAKTHRES) {
                m_serialNumber++;
                if (m_ruleStack.Count != 0) {
                    m_previousRule = m_ruleStack.Peek();
                    m_writer.WriteLine("node [fillcolor=palegreen];");
                    m_writer.WriteLine("\"{0}\" -> \"{1}\";", m_previousRule, "XARAKTHRES_s" + m_serialNumber);
                }
            }

            if (node.Symbol.Type == GLOSSAParser.LOGIKES) {
                m_serialNumber++;
                if (m_ruleStack.Count != 0) {
                    m_previousRule = m_ruleStack.Peek();
                    m_writer.WriteLine("node [fillcolor=palegreen];");
                    m_writer.WriteLine("\"{0}\" -> \"{1}\";", m_previousRule, "LOGIKES_s" + m_serialNumber);
                }
            }

            if (node.Symbol.Type == GLOSSAParser.GRAPSE) {
                m_serialNumber++;
                if (m_ruleStack.Count != 0) {
                    m_previousRule = m_ruleStack.Peek();
                    m_writer.WriteLine("node [fillcolor=palegreen];");
                    m_writer.WriteLine("\"{0}\" -> \"{1}\";", m_previousRule, "GRAPSE_s" + m_serialNumber);
                }
            }

            if (node.Symbol.Type == GLOSSAParser.EKTIPOSE) {
                m_serialNumber++;
                if (m_ruleStack.Count != 0) {
                    m_previousRule = m_ruleStack.Peek();
                    m_writer.WriteLine("node [fillcolor=palegreen];");
                    m_writer.WriteLine("\"{0}\" -> \"{1}\";", m_previousRule, "EKTIPOSE_s" + m_serialNumber);
                }
            }

            if (node.Symbol.Type == GLOSSAParser.DIABASE) {
                m_serialNumber++;
                if (m_ruleStack.Count != 0) {
                    m_previousRule = m_ruleStack.Peek();
                    m_writer.WriteLine("node [fillcolor=palegreen];");
                    m_writer.WriteLine("\"{0}\" -> \"{1}\";", m_previousRule, "DIABASE_s" + m_serialNumber);
                }
            }

            if (node.Symbol.Type == GLOSSAParser.KALESE) {
                m_serialNumber++;
                if (m_ruleStack.Count != 0) {
                    m_previousRule = m_ruleStack.Peek();
                    m_writer.WriteLine("node [fillcolor=palegreen];");
                    m_writer.WriteLine("\"{0}\" -> \"{1}\";", m_previousRule, "KALESE_s" + m_serialNumber);
                }
            }

            if (node.Symbol.Type == GLOSSAParser.TRUE) {
                m_serialNumber++;
                if (m_ruleStack.Count != 0) {
                    m_previousRule = m_ruleStack.Peek();
                    m_writer.WriteLine("node [fillcolor=palegreen];");
                    m_writer.WriteLine("\"{0}\" -> \"{1}\";", m_previousRule, "TRUE_s" + m_serialNumber);
                }
            }

            if (node.Symbol.Type == GLOSSAParser.FALSE) {
                m_serialNumber++;
                if (m_ruleStack.Count != 0) {
                    m_previousRule = m_ruleStack.Peek();
                    m_writer.WriteLine("node [fillcolor=palegreen];");
                    m_writer.WriteLine("\"{0}\" -> \"{1}\";", m_previousRule, "FALSE_s" + m_serialNumber);
                }
            }

            if (node.Symbol.Type == GLOSSAParser.IDENTIFIER) {
                m_serialNumber++;
                if (m_ruleStack.Count != 0) {
                    m_previousRule = m_ruleStack.Peek();
                    m_writer.WriteLine("node [fillcolor=palegreen];");
                    m_writer.WriteLine("\"{0}\" -> \"{1}\";", m_previousRule, node.GetText() + "_IDENTIFIER_s" + m_serialNumber);
                }
            }

            if (node.Symbol.Type == GLOSSAParser.EQUALS) {
                m_serialNumber++;
                if (m_ruleStack.Count != 0) {
                    m_previousRule = m_ruleStack.Peek();
                    m_writer.WriteLine("node [fillcolor=palegreen];");
                    m_writer.WriteLine("\"{0}\" -> \"{1}\";", m_previousRule, "EQUALS_s" + m_serialNumber);
                }
            }

            if (node.Symbol.Type == GLOSSAParser.NOTEQUALS) {
                m_serialNumber++;
                if (m_ruleStack.Count != 0) {
                    m_previousRule = m_ruleStack.Peek();
                    m_writer.WriteLine("node [fillcolor=palegreen];");
                    m_writer.WriteLine("\"{0}\" -> \"{1}\";", m_previousRule, "NOTEQUALS_s" + m_serialNumber);
                }
            }

            if (node.Symbol.Type == GLOSSAParser.GT) {
                m_serialNumber++;
                if (m_ruleStack.Count != 0) {
                    m_previousRule = m_ruleStack.Peek();
                    m_writer.WriteLine("node [fillcolor=palegreen];");
                    m_writer.WriteLine("\"{0}\" -> \"{1}\";", m_previousRule, "GT_s" + m_serialNumber);
                }
            }

            if (node.Symbol.Type == GLOSSAParser.GE) {
                m_serialNumber++;
                if (m_ruleStack.Count != 0) {
                    m_previousRule = m_ruleStack.Peek();
                    m_writer.WriteLine("node [fillcolor=palegreen];");
                    m_writer.WriteLine("\"{0}\" -> \"{1}\";", m_previousRule, "GE_s" + m_serialNumber);
                }
            }

            if (node.Symbol.Type == GLOSSAParser.LT) {
                m_serialNumber++;
                if (m_ruleStack.Count != 0) {
                    m_previousRule = m_ruleStack.Peek();
                    m_writer.WriteLine("node [fillcolor=palegreen];");
                    m_writer.WriteLine("\"{0}\" -> \"{1}\";", m_previousRule, "LT_s" + m_serialNumber);
                }
            }

            if (node.Symbol.Type == GLOSSAParser.LE) {
                m_serialNumber++;
                if (m_ruleStack.Count != 0) {
                    m_previousRule = m_ruleStack.Peek();
                    m_writer.WriteLine("node [fillcolor=palegreen];");
                    m_writer.WriteLine("\"{0}\" -> \"{1}\";", m_previousRule, "LE_s" + m_serialNumber);
                }
            }

            if (node.Symbol.Type == GLOSSAParser.PLUS) {
                m_serialNumber++;
                if (m_ruleStack.Count != 0) {
                    m_previousRule = m_ruleStack.Peek();
                    m_writer.WriteLine("node [fillcolor=palegreen];");
                    m_writer.WriteLine("\"{0}\" -> \"{1}\";", m_previousRule, "PLUS_s" + m_serialNumber);
                }
            }

            if (node.Symbol.Type == GLOSSAParser.MINUS) {
                m_serialNumber++;
                if (m_ruleStack.Count != 0) {
                    m_previousRule = m_ruleStack.Peek();
                    m_writer.WriteLine("node [fillcolor=palegreen];");
                    m_writer.WriteLine("\"{0}\" -> \"{1}\";", m_previousRule, "MINUS_s" + m_serialNumber);
                }
            }

            if (node.Symbol.Type == GLOSSAParser.MUL) {
                m_serialNumber++;
                if (m_ruleStack.Count != 0) {
                    m_previousRule = m_ruleStack.Peek();
                    m_writer.WriteLine("node [fillcolor=palegreen];");
                    m_writer.WriteLine("\"{0}\" -> \"{1}\";", m_previousRule, "MUL_s" + m_serialNumber);
                }
            }

            if (node.Symbol.Type == GLOSSAParser.DIV) {
                m_serialNumber++;
                if (m_ruleStack.Count != 0) {
                    m_previousRule = m_ruleStack.Peek();
                    m_writer.WriteLine("node [fillcolor=palegreen];");
                    m_writer.WriteLine("\"{0}\" -> \"{1}\";", m_previousRule, "DIV_s" + m_serialNumber);
                }
            }

            if (node.Symbol.Type == GLOSSAParser.POWER) {
                m_serialNumber++;
                if (m_ruleStack.Count != 0) {
                    m_previousRule = m_ruleStack.Peek();
                    m_writer.WriteLine("node [fillcolor=palegreen];");
                    m_writer.WriteLine("\"{0}\" -> \"{1}\";", m_previousRule, "POWER_s" + m_serialNumber);
                }
            }

            if (node.Symbol.Type == GLOSSAParser.SEMICOLON) {
                m_serialNumber++;
                if (m_ruleStack.Count != 0) {
                    m_previousRule = m_ruleStack.Peek();
                    m_writer.WriteLine("node [fillcolor=palegreen];");
                    m_writer.WriteLine("\"{0}\" -> \"{1}\";", m_previousRule, "SEMICOLON_s" + m_serialNumber);
                }
            }

            if (node.Symbol.Type == GLOSSAParser.COMMA) {
                m_serialNumber++;
                if (m_ruleStack.Count != 0) {
                    m_previousRule = m_ruleStack.Peek();
                    m_writer.WriteLine("node [fillcolor=palegreen];");
                    m_writer.WriteLine("\"{0}\" -> \"{1}\";", m_previousRule, "COMMA_s" + m_serialNumber);
                }
            }

            if (node.Symbol.Type == GLOSSAParser.ASSIGNMENT) {
                m_serialNumber++;
                if (m_ruleStack.Count != 0) {
                    m_previousRule = m_ruleStack.Peek();
                    m_writer.WriteLine("node [fillcolor=palegreen];");
                    m_writer.WriteLine("\"{0}\" -> \"{1}\";", m_previousRule, "ASSIGNMENT_s" + m_serialNumber);
                }
            }

            if (node.Symbol.Type == GLOSSAParser.LPAREN) {
                m_serialNumber++;
                if (m_ruleStack.Count != 0) {
                    m_previousRule = m_ruleStack.Peek();
                    m_writer.WriteLine("node [fillcolor=palegreen];");
                    m_writer.WriteLine("\"{0}\" -> \"{1}\";", m_previousRule, "LPAREN_s" + m_serialNumber);
                }
            }

            if (node.Symbol.Type == GLOSSAParser.RPAREN) {
                m_serialNumber++;
                if (m_ruleStack.Count != 0) {
                    m_previousRule = m_ruleStack.Peek();
                    m_writer.WriteLine("node [fillcolor=palegreen];");
                    m_writer.WriteLine("\"{0}\" -> \"{1}\";", m_previousRule, "RPAREN_s" + m_serialNumber);
                }
            }

            if (node.Symbol.Type == GLOSSAParser.LBRACKET) {
                m_serialNumber++;
                if (m_ruleStack.Count != 0) {
                    m_previousRule = m_ruleStack.Peek();
                    m_writer.WriteLine("node [fillcolor=palegreen];");
                    m_writer.WriteLine("\"{0}\" -> \"{1}\";", m_previousRule, "LBRACKET_s" + m_serialNumber);
                }
            }

            if (node.Symbol.Type == GLOSSAParser.RBRACKET) {
                m_serialNumber++;
                if (m_ruleStack.Count != 0) {
                    m_previousRule = m_ruleStack.Peek();
                    m_writer.WriteLine("node [fillcolor=palegreen];");
                    m_writer.WriteLine("\"{0}\" -> \"{1}\";", m_previousRule, "RBRACKET_s" + m_serialNumber);
                }
            }

            if (node.Symbol.Type == GLOSSAParser.LANCHOR) {
                m_serialNumber++;
                if (m_ruleStack.Count != 0) {
                    m_previousRule = m_ruleStack.Peek();
                    m_writer.WriteLine("node [fillcolor=palegreen];");
                    m_writer.WriteLine("\"{0}\" -> \"{1}\";", m_previousRule, "LANCHOR_s" + m_serialNumber);
                }
            }

            if (node.Symbol.Type == GLOSSAParser.RANCHOR) {
                m_serialNumber++;
                if (m_ruleStack.Count != 0) {
                    m_previousRule = m_ruleStack.Peek();
                    m_writer.WriteLine("node [fillcolor=palegreen];");
                    m_writer.WriteLine("\"{0}\" -> \"{1}\";", m_previousRule, "RANCHOR_s" + m_serialNumber);
                }
            }

            if (node.Symbol.Type == GLOSSAParser.A_M) {
                m_serialNumber++;
                if (m_ruleStack.Count != 0) {
                    m_previousRule = m_ruleStack.Peek();
                    m_writer.WriteLine("node [fillcolor=palegreen];");
                    m_writer.WriteLine("\"{0}\" -> \"{1}\";", m_previousRule, "A_M_s" + m_serialNumber);
                }
            }

            if (node.Symbol.Type == GLOSSAParser.A_T) {
                m_serialNumber++;
                if (m_ruleStack.Count != 0) {
                    m_previousRule = m_ruleStack.Peek();
                    m_writer.WriteLine("node [fillcolor=palegreen];");
                    m_writer.WriteLine("\"{0}\" -> \"{1}\";", m_previousRule, "A_T_s" + m_serialNumber);
                }
            }

            if (node.Symbol.Type == GLOSSAParser.E) {
                m_serialNumber++;
                if (m_ruleStack.Count != 0) {
                    m_previousRule = m_ruleStack.Peek();
                    m_writer.WriteLine("node [fillcolor=palegreen];");
                    m_writer.WriteLine("\"{0}\" -> \"{1}\";", m_previousRule, "E_s" + m_serialNumber);
                }
            }

            if (node.Symbol.Type == GLOSSAParser.EF) {
                m_serialNumber++;
                if (m_ruleStack.Count != 0) {
                    m_previousRule = m_ruleStack.Peek();
                    m_writer.WriteLine("node [fillcolor=palegreen];");
                    m_writer.WriteLine("\"{0}\" -> \"{1}\";", m_previousRule, "EF_s" + m_serialNumber);
                }
            }

            if (node.Symbol.Type == GLOSSAParser.HM) {
                m_serialNumber++;
                if (m_ruleStack.Count != 0) {
                    m_previousRule = m_ruleStack.Peek();
                    m_writer.WriteLine("node [fillcolor=palegreen];");
                    m_writer.WriteLine("\"{0}\" -> \"{1}\";", m_previousRule, "HM_s" + m_serialNumber);
                }
            }

            if (node.Symbol.Type == GLOSSAParser.LOG) {
                m_serialNumber++;
                if (m_ruleStack.Count != 0) {
                    m_previousRule = m_ruleStack.Peek();
                    m_writer.WriteLine("node [fillcolor=palegreen];");
                    m_writer.WriteLine("\"{0}\" -> \"{1}\";", m_previousRule, "LOG_s" + m_serialNumber);
                }
            }

            if (node.Symbol.Type == GLOSSAParser.SYN) {
                m_serialNumber++;
                if (m_ruleStack.Count != 0) {
                    m_previousRule = m_ruleStack.Peek();
                    m_writer.WriteLine("node [fillcolor=palegreen];");
                    m_writer.WriteLine("\"{0}\" -> \"{1}\";", m_previousRule, "SYN_s" + m_serialNumber);
                }
            }

            if (node.Symbol.Type == GLOSSAParser.T_R) {
                m_serialNumber++;
                if (m_ruleStack.Count != 0) {
                    m_previousRule = m_ruleStack.Peek();
                    m_writer.WriteLine("node [fillcolor=palegreen];");
                    m_writer.WriteLine("\"{0}\" -> \"{1}\";", m_previousRule, "T_R_s" + m_serialNumber);
                }
            }
        }



        /*************************************************************************************************/
        /*************************************************************************************************/
        /*                                         EXIT METHODS                                          */
        /*************************************************************************************************/
        /*************************************************************************************************/

        public override void ExitFilestart(GLOSSAParser.FilestartContext context) {
            m_previousRule = m_ruleStack.Pop();

            // Close graph
            m_writer.WriteLine("}");

            // Close stream
            m_writer.Close();
        }

        public override void ExitProgramstart(GLOSSAParser.ProgramstartContext context) {
            m_previousRule = m_ruleStack.Pop();
            m_previousRule = m_ruleStack.Peek();
        }

        public override void ExitStmtlist(GLOSSAParser.StmtlistContext context) {
            m_previousRule = m_ruleStack.Pop();
            m_previousRule = m_ruleStack.Peek();
        }

        public override void ExitStat_expr(GLOSSAParser.Stat_exprContext context) {
            m_previousRule = m_ruleStack.Pop();
            m_previousRule = m_ruleStack.Peek();
        }

        public override void ExitStat_assignment(GLOSSAParser.Stat_assignmentContext context) {
            m_previousRule = m_ruleStack.Pop();
            m_previousRule = m_ruleStack.Peek();
        }

        public override void ExitStat_ioexpr(GLOSSAParser.Stat_ioexprContext context) {
            m_previousRule = m_ruleStack.Pop();
            m_previousRule = m_ruleStack.Peek();
        }

        public override void ExitStat_ifctrl(GLOSSAParser.Stat_ifctrlContext context) {
            m_previousRule = m_ruleStack.Pop();
            m_previousRule = m_ruleStack.Peek();
        }

        public override void ExitStat_dowhile(GLOSSAParser.Stat_dowhileContext context) {
            m_previousRule = m_ruleStack.Pop();
            m_previousRule = m_ruleStack.Peek();
        }

        public override void ExitStat_while(GLOSSAParser.Stat_whileContext context) {
            m_previousRule = m_ruleStack.Pop();
            m_previousRule = m_ruleStack.Peek();
        }

        public override void ExitStat_switch(GLOSSAParser.Stat_switchContext context) {
            m_previousRule = m_ruleStack.Pop();
            m_previousRule = m_ruleStack.Peek();
        }

        public override void ExitVardecl(GLOSSAParser.VardeclContext context) {
            m_previousRule = m_ruleStack.Pop();
            m_previousRule = m_ruleStack.Peek();
        }

        public override void ExitConstdecl(GLOSSAParser.ConstdeclContext context) {
            m_previousRule = m_ruleStack.Pop();
            m_previousRule = m_ruleStack.Peek();
        }

        public override void ExitFuncdef1(GLOSSAParser.Funcdef1Context context) {
            m_previousRule = m_ruleStack.Pop();
            m_previousRule = m_ruleStack.Peek();
        }

        public override void ExitFuncdef2(GLOSSAParser.Funcdef2Context context) {
            m_previousRule = m_ruleStack.Pop();
            m_previousRule = m_ruleStack.Peek();
        }

        public override void ExitProcdef1(GLOSSAParser.Procdef1Context context) {
            m_previousRule = m_ruleStack.Pop();
            m_previousRule = m_ruleStack.Peek();
        }

        public override void ExitProcdef2(GLOSSAParser.Procdef2Context context) {
            m_previousRule = m_ruleStack.Pop();
            m_previousRule = m_ruleStack.Peek();
        }

        public override void ExitVardecl_alt1(GLOSSAParser.Vardecl_alt1Context context) {
            m_previousRule = m_ruleStack.Pop();
            m_previousRule = m_ruleStack.Peek();
        }

        public override void ExitVardecl_alt2(GLOSSAParser.Vardecl_alt2Context context) {
            m_previousRule = m_ruleStack.Pop();
            m_previousRule = m_ruleStack.Peek();
        }

        public override void ExitConstdecl_alt1(GLOSSAParser.Constdecl_alt1Context context) {
            m_previousRule = m_ruleStack.Pop();
            m_previousRule = m_ruleStack.Peek();
        }

        public override void ExitIfctrl(GLOSSAParser.IfctrlContext context) {
            m_previousRule = m_ruleStack.Pop();
            m_previousRule = m_ruleStack.Peek();
        }

        public override void ExitElseifctrl(GLOSSAParser.ElseifctrlContext context) {
            m_previousRule = m_ruleStack.Pop();
            m_previousRule = m_ruleStack.Peek();
        }

        public override void ExitElsectrl(GLOSSAParser.ElsectrlContext context) {
            m_previousRule = m_ruleStack.Pop();
            m_previousRule = m_ruleStack.Peek();
        }

        public override void ExitDowhilectrl(GLOSSAParser.DowhilectrlContext context) {
            m_previousRule = m_ruleStack.Pop();
            m_previousRule = m_ruleStack.Peek();
        }

        public override void ExitWhilectrl(GLOSSAParser.WhilectrlContext context) {
            m_previousRule = m_ruleStack.Pop();
            m_previousRule = m_ruleStack.Peek();
        }

        public override void ExitForctrl(GLOSSAParser.ForctrlContext context) {
            m_previousRule = m_ruleStack.Pop();
            m_previousRule = m_ruleStack.Peek();
        }

        public override void ExitSwitchctrl(GLOSSAParser.SwitchctrlContext context) {
            m_previousRule = m_ruleStack.Pop();
            m_previousRule = m_ruleStack.Peek();
        }

        public override void ExitCasectrl(GLOSSAParser.CasectrlContext context) {
            m_previousRule = m_ruleStack.Pop();
            m_previousRule = m_ruleStack.Peek();
        }

        public override void ExitOtherwisectrl(GLOSSAParser.OtherwisectrlContext context) {
            m_previousRule = m_ruleStack.Pop();
            m_previousRule = m_ruleStack.Peek();
        }

        public override void ExitFunargs(GLOSSAParser.FunargsContext context) {
            m_previousRule = m_ruleStack.Pop();
            m_previousRule = m_ruleStack.Peek();
        }

        public override void ExitAssign(GLOSSAParser.AssignContext context) {
            m_previousRule = m_ruleStack.Pop();
            m_previousRule = m_ruleStack.Peek();
        }

        public override void ExitExpr_paren(GLOSSAParser.Expr_parenContext context) {
            m_previousRule = m_ruleStack.Pop();
            m_previousRule = m_ruleStack.Peek();
        }

        public override void ExitExpr_power(GLOSSAParser.Expr_powerContext context) {
            m_previousRule = m_ruleStack.Pop();
            m_previousRule = m_ruleStack.Peek();
        }

        public override void ExitExpr_unary(GLOSSAParser.Expr_unaryContext context) {
            m_previousRule = m_ruleStack.Pop();
            m_previousRule = m_ruleStack.Peek();
        }

        public override void ExitExpr_muldiv(GLOSSAParser.Expr_muldivContext context) {
            m_previousRule = m_ruleStack.Pop();
            m_previousRule = m_ruleStack.Peek();
        }

        public override void ExitExpr_plusminus(GLOSSAParser.Expr_plusminusContext context) {
            m_previousRule = m_ruleStack.Pop();
            m_previousRule = m_ruleStack.Peek();
        }

        public override void ExitExpr_compare(GLOSSAParser.Expr_compareContext context) {
            m_previousRule = m_ruleStack.Pop();
            m_previousRule = m_ruleStack.Peek();
        }

        public override void ExitExpr_funcproccall(GLOSSAParser.Expr_funcproccallContext context) {
            m_previousRule = m_ruleStack.Pop();
            m_previousRule = m_ruleStack.Peek();
        }

        public override void ExitExpr_expressionprimitives(GLOSSAParser.Expr_expressionprimitivesContext context) {
            m_previousRule = m_ruleStack.Pop();
            m_previousRule = m_ruleStack.Peek();
        }

        public override void ExitExpressionprimitives_int(GLOSSAParser.Expressionprimitives_intContext context) {
            m_serialNumber++;
            if (m_ruleStack.Count != 0) {
                m_previousRule = m_ruleStack.Peek();
                m_writer.WriteLine("node [fillcolor=palegreen];");
                m_writer.WriteLine("\"{0}\" -> \"{1}\";", m_previousRule, context.GetText() + "_INTEGER_s" + m_serialNumber);
            }
        }

        public override void ExitExpressionprimitives_dec(GLOSSAParser.Expressionprimitives_decContext context) {
            m_serialNumber++;
            if (m_ruleStack.Count != 0) {
                m_previousRule = m_ruleStack.Peek();
                m_writer.WriteLine("node [fillcolor=palegreen];");
                m_writer.WriteLine("\"{0}\" -> \"{1}\";", m_previousRule, context.GetText() + "_DECIMAL_s" + m_serialNumber);
            }
        }

        public override void ExitExpressionprimitives_string(GLOSSAParser.Expressionprimitives_stringContext context) {
            m_serialNumber++;
            if (m_ruleStack.Count != 0) {
                m_previousRule = m_ruleStack.Peek();
                m_writer.WriteLine("node [fillcolor=palegreen];");
                m_writer.WriteLine("\"{0}\" -> \"{1}\";", m_previousRule, context.GetText() + "_STRING_s" + m_serialNumber);
            }
        }
    }
}