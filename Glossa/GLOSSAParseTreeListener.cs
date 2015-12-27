using Antlr4.Runtime.Tree;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Text.RegularExpressions;

namespace Glossa {
    public class GLOSSAParseTreeListener : GLOSSABaseListener {
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
        /// We check if the terminal element we matched is a reserved word.
        /// </summary>
        private bool m_keyword = false;

        private StreamWriter m_writer;

        public GLOSSAParseTreeListener(string filename) {
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
                m_writer.WriteLine("\"{0}\" -> \"{1}\";", m_previousRule, "stat_forctrl_" + m_serialNumber);
            }

            m_ruleStack.Push("stat_forctrl_" + m_serialNumber);
            m_previousRule = "stat_forctrl_" + m_serialNumber;
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

        public override void EnterExpr_muldiv(GLOSSAParser.Expr_muldivContext context) {
            if (context.op.Type == GLOSSAParser.MUL) {
                m_serialNumber++;
                // Print edge from the parent to the child
                if (m_ruleStack.Count != 0) {
                    m_previousRule = m_ruleStack.Peek();
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

        public override void EnterExpressionprimitives_int(GLOSSAParser.Expressionprimitives_intContext context) {
            base.EnterExpressionprimitives_int(context);
        }

        public override void EnterExpressionprimitives_dec(GLOSSAParser.Expressionprimitives_decContext context) {
            base.EnterExpressionprimitives_dec(context);
        }

        public override void EnterExpressionprimitives_string(GLOSSAParser.Expressionprimitives_stringContext context) {
            base.EnterExpressionprimitives_string(context);
        }

        public override void EnterExpressionprimitives_identifier(GLOSSAParser.Expressionprimitives_identifierContext context) {
            base.EnterExpressionprimitives_identifier(context);
        }

        public override void EnterType_akeraies(GLOSSAParser.Type_akeraiesContext context) {
            base.EnterType_akeraies(context);
        }

        public override void EnterType_pragmatikes(GLOSSAParser.Type_pragmatikesContext context) {
            base.EnterType_pragmatikes(context);
        }

        public override void EnterType_xaraktires(GLOSSAParser.Type_xaraktiresContext context) {
            base.EnterType_xaraktires(context);
        }

        public override void EnterType_logikes(GLOSSAParser.Type_logikesContext context) {
            base.EnterType_logikes(context);
        }

        public override void EnterKeyword_grapse(GLOSSAParser.Keyword_grapseContext context) {
            base.EnterKeyword_grapse(context);
        }

        public override void EnterKeyword_ektipose(GLOSSAParser.Keyword_ektiposeContext context) {
            base.EnterKeyword_ektipose(context);
        }

        public override void EnterKeyword_diabase(GLOSSAParser.Keyword_diabaseContext context) {
            base.EnterKeyword_diabase(context);
        }

        public override void EnterKeyword_kalese(GLOSSAParser.Keyword_kaleseContext context) {
            base.EnterKeyword_kalese(context);
        }

        public override void EnterBool_true(GLOSSAParser.Bool_trueContext context) {
            base.EnterBool_true(context);
        }

        public override void EnterBool_false(GLOSSAParser.Bool_falseContext context) {
            base.EnterBool_false(context);
        }

        public override void VisitTerminal(ITerminalNode node) {
            if (node.Symbol.Type == GLOSSAParser.PROGRAMMA) {
                m_keyword = true;
                m_serialNumber++;
                if (m_ruleStack.Count != 0) {
                    m_previousRule = m_ruleStack.Peek();
                    m_writer.WriteLine("node [fillcolor=palegreen];");
                    m_writer.WriteLine("\"{0}\" -> \"{1}\";", m_previousRule, "PROGRAMMA_" + m_serialNumber);
                }
            }

            if (node.Symbol.Type == GLOSSAParser.ARXH) {
                m_keyword = true;
                m_serialNumber++;
                if (m_ruleStack.Count != 0) {
                    m_previousRule = m_ruleStack.Peek();
                    m_writer.WriteLine("node [fillcolor=palegreen];");
                    m_writer.WriteLine("\"{0}\" -> \"{1}\";", m_previousRule, "ARXH_" + m_serialNumber);
                }
            }

            if (node.Symbol.Type == GLOSSAParser.TELOS_PROGRAMMATOS) {
                m_keyword = true;
                m_serialNumber++;
                if (m_ruleStack.Count != 0) {
                    m_previousRule = m_ruleStack.Peek();
                    m_writer.WriteLine("node [fillcolor=palegreen];");
                    m_writer.WriteLine("\"{0}\" -> \"{1}\";", m_previousRule, "TELOS_PROGRAMMATOS_" + m_serialNumber);
                }
            }

            if (node.Symbol.Type == GLOSSAParser.SYNARTHSH) {
                m_keyword = true;
                m_serialNumber++;
                if (m_ruleStack.Count != 0) {
                    m_previousRule = m_ruleStack.Peek();
                    m_writer.WriteLine("node [fillcolor=palegreen];");
                    m_writer.WriteLine("\"{0}\" -> \"{1}\";", m_previousRule, "SYNARTHSH_" + m_serialNumber);
                }
            }

            if (node.Symbol.Type == GLOSSAParser.TELOS_SYNARTHSHS) {
                m_keyword = true;
                m_serialNumber++;
                if (m_ruleStack.Count != 0) {
                    m_previousRule = m_ruleStack.Peek();
                    m_writer.WriteLine("node [fillcolor=palegreen];");
                    m_writer.WriteLine("\"{0}\" -> \"{1}\";", m_previousRule, "TELOS_SYNARTHSHS_" + m_serialNumber);
                }
            }

            if (node.Symbol.Type == GLOSSAParser.DIADIKASIA) {
                m_keyword = true;
                m_serialNumber++;
                if (m_ruleStack.Count != 0) {
                    m_previousRule = m_ruleStack.Peek();
                    m_writer.WriteLine("node [fillcolor=palegreen];");
                    m_writer.WriteLine("\"{0}\" -> \"{1}\";", m_previousRule, "DIADIKASIA_" + m_serialNumber);
                }
            }

            if (node.Symbol.Type == GLOSSAParser.TELOS_DIADIKASIAS) {
                m_keyword = true;
                m_serialNumber++;
                if (m_ruleStack.Count != 0) {
                    m_previousRule = m_ruleStack.Peek();
                    m_writer.WriteLine("node [fillcolor=palegreen];");
                    m_writer.WriteLine("\"{0}\" -> \"{1}\";", m_previousRule, "TELOS_DIADIKASIAS_" + m_serialNumber);
                }
            }

            if (node.Symbol.Type == GLOSSAParser.METABLHTES) {
                m_keyword = true;
                m_serialNumber++;
                if (m_ruleStack.Count != 0) {
                    m_previousRule = m_ruleStack.Peek();
                    m_writer.WriteLine("node [fillcolor=palegreen];");
                    m_writer.WriteLine("\"{0}\" -> \"{1}\";", m_previousRule, "METABLHTES_" + m_serialNumber);
                }
            }

            if (node.Symbol.Type == GLOSSAParser.STATHERES) {
                m_keyword = true;
                m_serialNumber++;
                if (m_ruleStack.Count != 0) {
                    m_previousRule = m_ruleStack.Peek();
                    m_writer.WriteLine("node [fillcolor=palegreen];");
                    m_writer.WriteLine("\"{0}\" -> \"{1}\";", m_previousRule, "STATHERES_" + m_serialNumber);
                }
            }

            if (node.Symbol.Type == GLOSSAParser.AN) {
                m_keyword = true;
                m_serialNumber++;
                if (m_ruleStack.Count != 0) {
                    m_previousRule = m_ruleStack.Peek();
                    m_writer.WriteLine("node [fillcolor=palegreen];");
                    m_writer.WriteLine("\"{0}\" -> \"{1}\";", m_previousRule, "AN_" + m_serialNumber);
                }
            }

            if (node.Symbol.Type == GLOSSAParser.TOTE) {
                m_keyword = true;
                m_serialNumber++;
                if (m_ruleStack.Count != 0) {
                    m_previousRule = m_ruleStack.Peek();
                    m_writer.WriteLine("node [fillcolor=palegreen];");
                    m_writer.WriteLine("\"{0}\" -> \"{1}\";", m_previousRule, "TOTE_" + m_serialNumber);
                }
            }

            if (node.Symbol.Type == GLOSSAParser.TELOS_AN) {
                m_keyword = true;
                m_serialNumber++;
                if (m_ruleStack.Count != 0) {
                    m_previousRule = m_ruleStack.Peek();
                    m_writer.WriteLine("node [fillcolor=palegreen];");
                    m_writer.WriteLine("\"{0}\" -> \"{1}\";", m_previousRule, "TELOS_AN_" + m_serialNumber);
                }
            }

            if (node.Symbol.Type == GLOSSAParser.ALLIOS_AN) {
                m_keyword = true;
                m_serialNumber++;
                if (m_ruleStack.Count != 0) {
                    m_previousRule = m_ruleStack.Peek();
                    m_writer.WriteLine("node [fillcolor=palegreen];");
                    m_writer.WriteLine("\"{0}\" -> \"{1}\";", m_previousRule, "ALLIOS_AN_" + m_serialNumber);
                }
            }

            if (node.Symbol.Type == GLOSSAParser.ALLIOS) {
                m_keyword = true;
                m_serialNumber++;
                if (m_ruleStack.Count != 0) {
                    m_previousRule = m_ruleStack.Peek();
                    m_writer.WriteLine("node [fillcolor=palegreen];");
                    m_writer.WriteLine("\"{0}\" -> \"{1}\";", m_previousRule, "ALLIOS_" + m_serialNumber);
                }
            }

            if (node.Symbol.Type == GLOSSAParser.AKERAIES) {
                m_keyword = true;
                m_serialNumber++;
                if (m_ruleStack.Count != 0) {
                    m_previousRule = m_ruleStack.Peek();
                    m_writer.WriteLine("node [fillcolor=palegreen];");
                    m_writer.WriteLine("\"{0}\" -> \"{1}\";", m_previousRule, "AKERAIES_" + m_serialNumber);
                }
            }

            if (node.Symbol.Type == GLOSSAParser.PRAGMATIKES) {
                m_keyword = true;
                m_serialNumber++;
                if (m_ruleStack.Count != 0) {
                    m_previousRule = m_ruleStack.Peek();
                    m_writer.WriteLine("node [fillcolor=palegreen];");
                    m_writer.WriteLine("\"{0}\" -> \"{1}\";", m_previousRule, "PRAGMATIKES_" + m_serialNumber);
                }
            }

            if (node.Symbol.Type == GLOSSAParser.XARAKTHRES) {
                m_keyword = true;
                m_serialNumber++;
                if (m_ruleStack.Count != 0) {
                    m_previousRule = m_ruleStack.Peek();
                    m_writer.WriteLine("node [fillcolor=palegreen];");
                    m_writer.WriteLine("\"{0}\" -> \"{1}\";", m_previousRule, "XARAKTHRES_" + m_serialNumber);
                }
            }

            if (node.Symbol.Type == GLOSSAParser.LOGIKES) {
                m_keyword = true;
                m_serialNumber++;
                if (m_ruleStack.Count != 0) {
                    m_previousRule = m_ruleStack.Peek();
                    m_writer.WriteLine("node [fillcolor=palegreen];");
                    m_writer.WriteLine("\"{0}\" -> \"{1}\";", m_previousRule, "LOGIKES_" + m_serialNumber);
                }
            }

            if (node.Symbol.Type == GLOSSAParser.GRAPSE) {
                m_keyword = true;
                m_serialNumber++;
                if (m_ruleStack.Count != 0) {
                    m_previousRule = m_ruleStack.Peek();
                    m_writer.WriteLine("node [fillcolor=palegreen];");
                    m_writer.WriteLine("\"{0}\" -> \"{1}\";", m_previousRule, "GRAPSE_" + m_serialNumber);
                }
            }

            if (node.Symbol.Type == GLOSSAParser.EKTIPOSE) {
                m_keyword = true;
                m_serialNumber++;
                if (m_ruleStack.Count != 0) {
                    m_previousRule = m_ruleStack.Peek();
                    m_writer.WriteLine("node [fillcolor=palegreen];");
                    m_writer.WriteLine("\"{0}\" -> \"{1}\";", m_previousRule, "EKTIPOSE_" + m_serialNumber);
                }
            }

            if (node.Symbol.Type == GLOSSAParser.DIABASE) {
                m_keyword = true;
                m_serialNumber++;
                if (m_ruleStack.Count != 0) {
                    m_previousRule = m_ruleStack.Peek();
                    m_writer.WriteLine("node [fillcolor=palegreen];");
                    m_writer.WriteLine("\"{0}\" -> \"{1}\";", m_previousRule, "DIABASE_" + m_serialNumber);
                }
            }

            if (node.Symbol.Type == GLOSSAParser.KALESE) {
                m_keyword = true;
                m_serialNumber++;
                if (m_ruleStack.Count != 0) {
                    m_previousRule = m_ruleStack.Peek();
                    m_writer.WriteLine("node [fillcolor=palegreen];");
                    m_writer.WriteLine("\"{0}\" -> \"{1}\";", m_previousRule, "KALESE_" + m_serialNumber);
                }
            }

            if (node.Symbol.Type == GLOSSAParser.TRUE) {
                m_keyword = true;
                m_serialNumber++;
                if (m_ruleStack.Count != 0) {
                    m_previousRule = m_ruleStack.Peek();
                    m_writer.WriteLine("node [fillcolor=palegreen];");
                    m_writer.WriteLine("\"{0}\" -> \"{1}\";", m_previousRule, "TRUE_" + m_serialNumber);
                }
            }

            if (node.Symbol.Type == GLOSSAParser.FALSE) {
                m_keyword = true;
                m_serialNumber++;
                if (m_ruleStack.Count != 0) {
                    m_previousRule = m_ruleStack.Peek();
                    m_writer.WriteLine("node [fillcolor=palegreen];");
                    m_writer.WriteLine("\"{0}\" -> \"{1}\";", m_previousRule, "FALSE_" + m_serialNumber);
                }
            }

            if (!m_keyword) {
                if (node.Symbol.Type == GLOSSAParser.IDENTIFIER) {
                    m_keyword = true;
                    m_serialNumber++;
                    if (m_ruleStack.Count != 0) {
                        m_previousRule = m_ruleStack.Peek();
                        m_writer.WriteLine("node [fillcolor=palegreen];");
                        m_writer.WriteLine("\"{0}\" -> \"{1}\";", m_previousRule, "IDENTIFIER_" + m_serialNumber);
                    }
                }
            }

            if (node.Symbol.Type == GLOSSAParser.EQUALS) {
                m_serialNumber++;
                if (m_ruleStack.Count != 0) {
                    m_previousRule = m_ruleStack.Peek();
                    m_writer.WriteLine("node [fillcolor=palegreen];");
                    m_writer.WriteLine("\"{0}\" -> \"{1}\";", m_previousRule, "EQUALS_" + m_serialNumber);
                }
            }

            if (node.Symbol.Type == GLOSSAParser.NOTEQUALS) {
                m_serialNumber++;
                if (m_ruleStack.Count != 0) {
                    m_previousRule = m_ruleStack.Peek();
                    m_writer.WriteLine("node [fillcolor=palegreen];");
                    m_writer.WriteLine("\"{0}\" -> \"{1}\";", m_previousRule, "NOTEQUALS_" + m_serialNumber);
                }
            }

            if (node.Symbol.Type == GLOSSAParser.GT) {
                m_serialNumber++;
                if (m_ruleStack.Count != 0) {
                    m_previousRule = m_ruleStack.Peek();
                    m_writer.WriteLine("node [fillcolor=palegreen];");
                    m_writer.WriteLine("\"{0}\" -> \"{1}\";", m_previousRule, "GT_" + m_serialNumber);
                }
            }

            if (node.Symbol.Type == GLOSSAParser.GE) {
                m_serialNumber++;
                if (m_ruleStack.Count != 0) {
                    m_previousRule = m_ruleStack.Peek();
                    m_writer.WriteLine("node [fillcolor=palegreen];");
                    m_writer.WriteLine("\"{0}\" -> \"{1}\";", m_previousRule, "GE_" + m_serialNumber);
                }
            }

            if (node.Symbol.Type == GLOSSAParser.LT) {
                m_serialNumber++;
                if (m_ruleStack.Count != 0) {
                    m_previousRule = m_ruleStack.Peek();
                    m_writer.WriteLine("node [fillcolor=palegreen];");
                    m_writer.WriteLine("\"{0}\" -> \"{1}\";", m_previousRule, "LT_" + m_serialNumber);
                }
            }

            if (node.Symbol.Type == GLOSSAParser.LE) {
                m_serialNumber++;
                if (m_ruleStack.Count != 0) {
                    m_previousRule = m_ruleStack.Peek();
                    m_writer.WriteLine("node [fillcolor=palegreen];");
                    m_writer.WriteLine("\"{0}\" -> \"{1}\";", m_previousRule, "LE_" + m_serialNumber);
                }
            }

            if (node.Symbol.Type == GLOSSAParser.PLUS) {
                m_serialNumber++;
                if (m_ruleStack.Count != 0) {
                    m_previousRule = m_ruleStack.Peek();
                    m_writer.WriteLine("node [fillcolor=palegreen];");
                    m_writer.WriteLine("\"{0}\" -> \"{1}\";", m_previousRule, "PLUS_" + m_serialNumber);
                }
            }

            if (node.Symbol.Type == GLOSSAParser.MINUS) {
                m_serialNumber++;
                if (m_ruleStack.Count != 0) {
                    m_previousRule = m_ruleStack.Peek();
                    m_writer.WriteLine("node [fillcolor=palegreen];");
                    m_writer.WriteLine("\"{0}\" -> \"{1}\";", m_previousRule, "MINUS_" + m_serialNumber);
                }
            }

            if (node.Symbol.Type == GLOSSAParser.MUL) {
                m_serialNumber++;
                if (m_ruleStack.Count != 0) {
                    m_previousRule = m_ruleStack.Peek();
                    m_writer.WriteLine("node [fillcolor=palegreen];");
                    m_writer.WriteLine("\"{0}\" -> \"{1}\";", m_previousRule, "MUL_" + m_serialNumber);
                }
            }

            if (node.Symbol.Type == GLOSSAParser.DIV) {
                m_serialNumber++;
                if (m_ruleStack.Count != 0) {
                    m_previousRule = m_ruleStack.Peek();
                    m_writer.WriteLine("node [fillcolor=palegreen];");
                    m_writer.WriteLine("\"{0}\" -> \"{1}\";", m_previousRule, "DIV_" + m_serialNumber);
                }
            }

            if (node.Symbol.Type == GLOSSAParser.POWER) {
                m_serialNumber++;
                if (m_ruleStack.Count != 0) {
                    m_previousRule = m_ruleStack.Peek();
                    m_writer.WriteLine("node [fillcolor=palegreen];");
                    m_writer.WriteLine("\"{0}\" -> \"{1}\";", m_previousRule, "POWER_" + m_serialNumber);
                }
            }

            if (node.Symbol.Type == GLOSSAParser.SEMICOLON) {
                m_serialNumber++;
                if (m_ruleStack.Count != 0) {
                    m_previousRule = m_ruleStack.Peek();
                    m_writer.WriteLine("node [fillcolor=palegreen];");
                    m_writer.WriteLine("\"{0}\" -> \"{1}\";", m_previousRule, "SEMICOLON_" + m_serialNumber);
                }
            }

            if (node.Symbol.Type == GLOSSAParser.COMMA) {
                m_serialNumber++;
                if (m_ruleStack.Count != 0) {
                    m_previousRule = m_ruleStack.Peek();
                    m_writer.WriteLine("node [fillcolor=palegreen];");
                    m_writer.WriteLine("\"{0}\" -> \"{1}\";", m_previousRule, "COMMA_" + m_serialNumber);
                }
            }

            if (node.Symbol.Type == GLOSSAParser.ASSIGNMENT) {
                m_serialNumber++;
                if (m_ruleStack.Count != 0) {
                    m_previousRule = m_ruleStack.Peek();
                    m_writer.WriteLine("node [fillcolor=palegreen];");
                    m_writer.WriteLine("\"{0}\" -> \"{1}\";", m_previousRule, "ASSIGNMENT_" + m_serialNumber);
                }
            }

            if (node.Symbol.Type == GLOSSAParser.LPAREN) {
                m_serialNumber++;
                if (m_ruleStack.Count != 0) {
                    m_previousRule = m_ruleStack.Peek();
                    m_writer.WriteLine("node [fillcolor=palegreen];");
                    m_writer.WriteLine("\"{0}\" -> \"{1}\";", m_previousRule, "LPAREN_" + m_serialNumber);
                }
            }

            if (node.Symbol.Type == GLOSSAParser.RPAREN) {
                m_serialNumber++;
                if (m_ruleStack.Count != 0) {
                    m_previousRule = m_ruleStack.Peek();
                    m_writer.WriteLine("node [fillcolor=palegreen];");
                    m_writer.WriteLine("\"{0}\" -> \"{1}\";", m_previousRule, "RPAREN_" + m_serialNumber);
                }
            }

            if (node.Symbol.Type == GLOSSAParser.LBRACKET) {
                m_serialNumber++;
                if (m_ruleStack.Count != 0) {
                    m_previousRule = m_ruleStack.Peek();
                    m_writer.WriteLine("node [fillcolor=palegreen];");
                    m_writer.WriteLine("\"{0}\" -> \"{1}\";", m_previousRule, "LBRACKET_" + m_serialNumber);
                }
            }

            if (node.Symbol.Type == GLOSSAParser.RBRACKET) {
                m_serialNumber++;
                if (m_ruleStack.Count != 0) {
                    m_previousRule = m_ruleStack.Peek();
                    m_writer.WriteLine("node [fillcolor=palegreen];");
                    m_writer.WriteLine("\"{0}\" -> \"{1}\";", m_previousRule, "RBRACKET_" + m_serialNumber);
                }
            }

            if (node.Symbol.Type == GLOSSAParser.LANCHOR) {
                m_serialNumber++;
                if (m_ruleStack.Count != 0) {
                    m_previousRule = m_ruleStack.Peek();
                    m_writer.WriteLine("node [fillcolor=palegreen];");
                    m_writer.WriteLine("\"{0}\" -> \"{1}\";", m_previousRule, "LANCHOR_" + m_serialNumber);
                }
            }

            if (node.Symbol.Type == GLOSSAParser.RANCHOR) {
                m_serialNumber++;
                if (m_ruleStack.Count != 0) {
                    m_previousRule = m_ruleStack.Peek();
                    m_writer.WriteLine("node [fillcolor=palegreen];");
                    m_writer.WriteLine("\"{0}\" -> \"{1}\";", m_previousRule, "RANCHOR_" + m_serialNumber);
                }
            }
            m_keyword = false;
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
                m_writer.WriteLine("\"{0}\" -> \"{1}\";", m_previousRule, "INTEGER_" + m_serialNumber);
            }
        }

        public override void ExitExpressionprimitives_dec(GLOSSAParser.Expressionprimitives_decContext context) {
            m_serialNumber++;
            if (m_ruleStack.Count != 0) {
                m_previousRule = m_ruleStack.Peek();
                m_writer.WriteLine("node [fillcolor=palegreen];");
                m_writer.WriteLine("\"{0}\" -> \"{1}\";", m_previousRule, "DECIMAL_" + m_serialNumber);
            }
        }

        public override void ExitExpressionprimitives_string(GLOSSAParser.Expressionprimitives_stringContext context) {
            m_serialNumber++;
            if (m_ruleStack.Count != 0) {
                m_previousRule = m_ruleStack.Peek();
                m_writer.WriteLine("node [fillcolor=palegreen];");
                m_writer.WriteLine("\"{0}\" -> \"{1}\";", m_previousRule, "STRING_" + m_serialNumber);
            }
        }
    }
}