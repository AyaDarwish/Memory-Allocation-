using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Memory_Allocation_Project
{
    public partial class Form1 : Form
    {
        static bool indicate = false;
        static bool flag_frag = false;
        static int frag_Counter = 0;
        DataTable P = new DataTable();
        DataTable H = new DataTable();
        DataTable R = new DataTable();
        DataTable F = new DataTable();

        public Form1()
        {
            InitializeComponent();
            H.Columns.Add("Hole Adress");
            H.Columns.Add("Hole Size");
            P.Columns.Add("Process Name");
            P.Columns.Add("Process Size");
            F.Columns.Add("frag Adress");
            F.Columns.Add("frag Size");
            R.Columns.Add("Address");
            R.Columns.Add("Status");
            R.Columns.Add("Size");
            P_DataTable.DataSource = P;
            H_DataTable.DataSource = H;
            F_DataTable.DataSource = F;
            Result_Table.DataSource = R;
        }
        class process
        {
            public string Name;
            public int p_Size;
            public int allocating_Address;
            public void set(string Name, int p_Size)
            {
                this.Name = Name;
                this.p_Size = p_Size;
            }
        }
        class fragmantation
        {
            public string f_Name = "Internal fragmentation";
            public int allocated_Address;
            public int frag_Size;
            public void set(int allocated_Address, int frag_Size)
            {
                this.allocated_Address = allocated_Address;
                this.frag_Size = frag_Size;
            }
        }
        class Hole
        {
            public string Name = "Hole";
            public int starting_Address;
            public int hole_Size;
            public void set(int starting_Address, int hole_Size)
            {
                this.starting_Address = starting_Address;
                this.hole_Size = hole_Size;
            }
        }
        class process_Hole
        {
            public string Name;
            public int Size;
            public int Address;
            public void set(string Name, int Size , int Address)
            {
                this.Name = Name;
                this.Size = Size;
                this.Address = Address; 
            }
        }
      
        static void Sort(List<Hole> Holes)
        {
            int temp1;
            for (int k = 0; k < Holes.Count() - 1; k++)
            {
                for (int l = k + 1; l < Holes.Count(); l++)
                {
                    if (Holes[k].starting_Address == Holes[l].starting_Address)
                    {
                        if (Holes[k].hole_Size > Holes[l].hole_Size)
                            Holes.RemoveAt(l);
                        else
                            Holes.RemoveAt(k);
                    }
                }
            }
            for (int i = 0; i < Holes.Count() - 1; i++)
            {
                for (int j = i + 1; j < Holes.Count(); j++)
                {
                    if (Holes[i].hole_Size >= Holes[j].hole_Size)
                    {
                        if (Holes[i].hole_Size > Holes[j].hole_Size)
                        {
                            temp1 = Holes[i].hole_Size;
                            Holes[i].hole_Size = Holes[j].hole_Size;
                            Holes[j].hole_Size = temp1;

                            temp1 = Holes[i].starting_Address;
                            Holes[i].starting_Address = Holes[j].starting_Address;
                            Holes[j].starting_Address = temp1;
                        }
                        else
                        {
                            if (Holes[i].starting_Address > Holes[j].starting_Address)
                            {
                                temp1 = Holes[i].hole_Size;
                                Holes[i].hole_Size = Holes[j].hole_Size;
                                Holes[j].hole_Size = temp1;

                                temp1 = Holes[i].starting_Address;
                                Holes[i].starting_Address = Holes[j].starting_Address;
                                Holes[j].starting_Address = temp1;
                            }
                        }
                    }
                }
            }
        }

        static void Sort_s(List<Hole> Holes)
        {
            int temp1;
            for (int i = 0; i < Holes.Count() - 1; i++)
            {
                for (int j = i + 1; j < Holes.Count(); j++)
                {
                    if (Holes[i].starting_Address > Holes[j].starting_Address)
                    {
                        temp1 = Holes[i].hole_Size;
                        Holes[i].hole_Size = Holes[j].hole_Size;
                        Holes[j].hole_Size = temp1;

                        temp1 = Holes[i].starting_Address;
                        Holes[i].starting_Address = Holes[j].starting_Address;
                        Holes[j].starting_Address = temp1;
                    }
                }
            }
        }
        static void Sort_chart(List<process_Hole> P_H)
        {
            int temp1;
            string temp;
            for (int i = 0; i < P_H.Count() - 1; i++)
            {
                for (int j = i + 1; j < P_H.Count(); j++)
                {
                    if (P_H[i].Address > P_H[j].Address)
                    {
                        temp1 = P_H[i].Size;
                        P_H[i].Size = P_H[j].Size;
                        P_H[j].Size = temp1;

                        temp1 = P_H[i].Address;
                        P_H[i].Address = P_H[j].Address;
                        P_H[j].Address = temp1;

                        temp = P_H[i].Name;
                        P_H[i].Name = P_H[j].Name;
                        P_H[j].Name = temp;
                    }
                }
            }
        }
        static int max(List<process> processes, List<fragmantation> frag)
        {
                int address_p = processes[0].allocating_Address + processes[0].p_Size;

                for (int i = 0; i < processes.Count() - 1; i++)
                {
                    for (int j = i + 1; j < processes.Count(); j++)
                    {
                        if (processes[i].allocating_Address > processes[j].allocating_Address)
                        {
                            address_p = processes[i].allocating_Address + processes[i].p_Size;
                        }
                        else
                            address_p = processes[j].allocating_Address + processes[j].p_Size;
                    }
                }
                if (frag.Count() > 0)
                {
                    int address_f = frag[0].allocated_Address + frag[0].frag_Size;
                    for (int i = 0; i < frag.Count() - 1; i++)
                    {
                        for (int j = i + 1; j < frag.Count(); j++)
                        {
                            if (frag[i].allocated_Address > frag[j].allocated_Address)
                            {
                                address_f = frag[i].allocated_Address + frag[i].frag_Size;
                            }
                            else
                                address_f = frag[j].allocated_Address + frag[j].frag_Size;
                        }
                    }
                    if (address_p > address_f)
                        return address_p;
                    else
                        return address_f;
                }
                else
                    return address_p;
        }
        static int sum_Size = 0;
        static int co = 0;
        static int Compaction(List<Hole> Holes, int no_Processes, List<process> processes, List<fragmantation> frag)
        {
            int holeSize = Holes[0].hole_Size;
            sum_Size += holeSize;
            co = 0;
            for (int i = 0; i < processes.Count(); i++)
            {
                if(processes[i].allocating_Address > Holes[0].starting_Address)
                {
                    co++;
                    processes[i].allocating_Address -= holeSize;               
                }
            }
            for (int i = 0; i < frag.Count(); i++)
            {
                if (frag[i].allocated_Address > Holes[0].starting_Address)
                {
                    co++;
                    frag[i].allocated_Address -= holeSize;
                }
            }
            for (int i = 1; i < Holes.Count(); i++)
            {
                if (Holes[i].starting_Address > Holes[0].starting_Address)
                {
                    co++;
                    Holes[i].starting_Address -= holeSize;
                }
            }
            if (co != 0)
            {
                Holes.RemoveAt(0);
                if (Holes.Count > 0)
                    Compaction(Holes, no_Processes, processes, frag);
            }
            return sum_Size;
        }
        static void First_Fit(List<Hole> Holes, int no_Processes, List<process> processes ,List<fragmantation>frag)
        {      
            bool flag = false;
            indicate = false;          
            flag_frag = false;
            for (int k = 0; k < Holes.Count() - 1; k++)
            {
                for (int l = k + 1; l < Holes.Count(); l++)
                {
                    if (Holes[k].starting_Address == Holes[l].starting_Address)
                    {
                        if (Holes[k].hole_Size > Holes[l].hole_Size)
                            Holes.RemoveAt(l);
                        else
                            Holes.RemoveAt(k);
                    }
                }
            }
            for (int j = 0; j < Holes.Count(); j++)
            {
                if (processes[processes.Count() - 1].p_Size <= Holes[j].hole_Size)
                {
                    flag = true;
                    processes[processes.Count() - 1].allocating_Address = Holes[j].starting_Address;
                    if (processes[processes.Count() - 1].p_Size == Holes[j].hole_Size)
                    {
                        Holes.RemoveAt(j);
                        flag_frag = true;
                    }
                    else
                    {
                        fragmantation temp = new fragmantation();
                        temp.allocated_Address = Holes[j].starting_Address + processes[processes.Count() - 1].p_Size;
                        temp.frag_Size = Holes[j].hole_Size - processes[processes.Count() - 1].p_Size;
                        frag.Add(temp);
                        frag_Counter++;
                        Holes.RemoveAt(j);
                    }
                    break;
                }
            }
            if (!flag && Holes.Count() > 1)
            {
                int address = max(processes, frag);
                Sort_s(Holes);
                sum_Size = 0;
                int holeS = Compaction(Holes, no_Processes, processes, frag);
                Hole temp = new Hole();
                temp.hole_Size = holeS;
                if (co != 0)
                    temp.starting_Address = address - holeS;
                else
                {
                    temp.starting_Address = Holes[0].starting_Address;
                    Holes.RemoveAt(0);
                }
                Holes.Add(temp);
                indicate = false;
                flag_frag = false;
                for (int k = 0; k < Holes.Count() - 1; k++)
                {
                    for (int l = k + 1; l < Holes.Count(); l++)
                    {
                        if (Holes[k].starting_Address == Holes[l].starting_Address)
                        {
                            if (Holes[k].hole_Size > Holes[l].hole_Size)
                                Holes.RemoveAt(l);
                            else
                                Holes.RemoveAt(k);
                        }
                    }
                }
                for (int j = 0; j < Holes.Count(); j++)
                {
                    if (processes[processes.Count() - 1].p_Size <= Holes[j].hole_Size)
                    {
                        flag = true;
                        processes[processes.Count() - 1].allocating_Address = Holes[j].starting_Address;
                        if (processes[processes.Count() - 1].p_Size == Holes[j].hole_Size)
                        {
                            Holes.RemoveAt(j);
                            flag_frag = true;
                        }
                        else
                        {
                            fragmantation temp1 = new fragmantation();
                            temp1.allocated_Address = Holes[j].starting_Address + processes[processes.Count() - 1].p_Size;
                            temp1.frag_Size = Holes[j].hole_Size - processes[processes.Count() - 1].p_Size;
                            frag.Add(temp1);
                            frag_Counter++;
                            Holes.RemoveAt(j);
                        }
                        break;
                    }
                }
                if (!flag)
                {
                    indicate = true;
                    processes.RemoveAt(processes.Count() - 1);
                }
            }
            else if (!flag )
            {
                indicate = true;
                processes.RemoveAt(processes.Count() - 1);
            }
        }
        static void Best_Fit(List<Hole> Holes, int no_Processes, List<process> processes, List<fragmantation> frag)
        {
            Sort(Holes);
            flag_frag = false;
            indicate = false;
            bool flag = false;
            for (int j = 0; j < Holes.Count(); j++)
            {
                if (processes[processes.Count() - 1].p_Size <= Holes[j].hole_Size)
                {
                    flag = true;
                    processes[processes.Count() - 1].allocating_Address = Holes[j].starting_Address;
                    if (processes[processes.Count() - 1].p_Size == Holes[j].hole_Size)
                    {
                        flag_frag = true;
                        Holes.RemoveAt(j);
                    }
                    else
                    {
                        fragmantation temp = new fragmantation();
                        temp.allocated_Address = Holes[j].starting_Address + processes[processes.Count() - 1].p_Size;
                        temp.frag_Size = Holes[j].hole_Size - processes[processes.Count() - 1].p_Size;
                        frag.Add(temp);
                        frag_Counter++;
                        Holes.RemoveAt(j);
                    }
                    break;
                }
            }
            if (!flag && Holes.Count() > 1)
            {
                int address = max(processes, frag);
                Sort_s(Holes);
                sum_Size = 0;
                int holeS = Compaction(Holes, no_Processes, processes, frag);
                Hole temp = new Hole();
                temp.hole_Size = holeS;
                if (co != 0)
                    temp.starting_Address = address - holeS;
                else
                {
                    temp.starting_Address = Holes[0].starting_Address;
                    Holes.RemoveAt(0);
                }
                Holes.Add(temp);
                Sort(Holes);
                flag_frag = false;
                indicate = false;
                for (int j = 0; j < Holes.Count(); j++)
                {
                    if (processes[processes.Count() - 1].p_Size <= Holes[j].hole_Size)
                    {
                        flag = true;
                        processes[processes.Count() - 1].allocating_Address = Holes[j].starting_Address;
                        if (processes[processes.Count() - 1].p_Size == Holes[j].hole_Size)
                        {
                            flag_frag = true;
                            Holes.RemoveAt(j);
                        }
                        else
                        {
                            fragmantation temp1 = new fragmantation();
                            temp1.allocated_Address = Holes[j].starting_Address + processes[processes.Count() - 1].p_Size;
                            temp1.frag_Size = Holes[j].hole_Size - processes[processes.Count() - 1].p_Size;
                            frag.Add(temp1);
                            frag_Counter++;
                            Holes.RemoveAt(j);
                        }
                        break;
                    }
                }
                if (!flag)
                {
                    indicate = true;
                    processes.RemoveAt(processes.Count() - 1);
                }
            }
            else if (!flag)
            {
                indicate = true;
                processes.RemoveAt(processes.Count() - 1);
            }

        }

        static void Allocate_Process(List<Hole> Holes, int no_Processes, List<process> processes, List<fragmantation> frag,string process_Name, int process_Size, int allocation_Type)
        {
            process temp_set = new process();
            temp_set.set(process_Name, process_Size);
            processes.Add(temp_set);
            if (allocation_Type == 1) // First_Fit Allocation Method
                First_Fit(Holes, no_Processes, processes ,frag);
            else if (allocation_Type == 2) // Best_Fit Allocation Method
                Best_Fit(Holes, no_Processes, processes , frag);
        }

        static void Allocate_Hole(List<Hole> Holes, int starting_Add, int Hole_Size)
        {
            Hole temp_set = new Hole();
            temp_set.set(starting_Add, Hole_Size);
            Holes.Add(temp_set);
        }

        static void de_Allocation(List<Hole> Holes, int no_Processes, List<process> processes,List<fragmantation> frag, string process_Name , ref int global , ref int frag_table)
        {
            for (int i = 0; i < processes.Count(); i++)
            {
                if (processes[i].Name == process_Name)
                {
                    global = i;
                    bool flag = false;
                    Hole temp_set = new Hole();
                    for (int j = 0; j < frag.Count(); j++)
                    {
                        if (processes[i].allocating_Address + processes[i].p_Size == frag[j].allocated_Address)
                        {
                            flag = true;
                            Hole temp = new Hole();
                            temp.set(processes[i].allocating_Address, frag[j].frag_Size + processes[i].p_Size);
                            Holes.Add(temp);
                            frag.RemoveAt(j);
                            frag_table = j;
                            frag_Counter--;
                            break;
                        }
                        else if (processes[i].allocating_Address - frag[j].frag_Size == frag[j].allocated_Address)
                        {
                            flag = true;
                            Hole temp = new Hole();
                            temp.set(Holes[j].starting_Address, frag[j].frag_Size + processes[i].p_Size);
                            Holes.Add(temp);
                            frag.RemoveAt(j);
                            frag_table = j;
                            frag_Counter--;
                            break;
                        }
                    }
                    if (!flag)
                    {
                        temp_set.set(processes[i].allocating_Address, processes[i].p_Size);
                        Holes.Add(temp_set);
                    }
                    processes.RemoveAt(i);
                    i--;
                    break;
                }
                else
                    global = -1;
            }
            Sort_s(Holes);
            for (int j = 0; j < Holes.Count() - 1; j++)
            {
                for (int k = j + 1; k < Holes.Count(); k++)
                {
                    if (Holes[j].starting_Address + Holes[j].hole_Size == Holes[k].starting_Address)
                    {
                        Holes[j].set(Holes[j].starting_Address, Holes[j].hole_Size + Holes[k].hole_Size);
                        Holes.RemoveAt(k);
                    }
                }
            }

        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void First_Fit_btn_CheckedChanged(object sender, EventArgs e)
        {     
            no_processes_textBox.Enabled = true;
            processName_textBox.Enabled = true;
            processSize_textBox.Enabled = true;
            ADD_process_Btn.Enabled = true;
            Deallocation_process_txBox.Enabled = true;
            Deallocate_Button.Enabled = true;
        }

        private void Best_Fit_btn_CheckedChanged(object sender, EventArgs e)
        {
            no_processes_textBox.Enabled = true;
            processName_textBox.Enabled = true;
            processSize_textBox.Enabled = true;
            ADD_process_Btn.Enabled = true;
            Deallocation_process_txBox.Enabled = true;
            Deallocate_Button.Enabled = true;
        }

        private void Restart_Btn_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }
        List<Hole> Holes = new List<Hole>();
        List<process> processes = new List<process>();
        List<process_Hole> p_H = new List<process_Hole>();
        List<fragmantation> frag = new List<fragmantation>();
        int H_Counter = 0;
        int p_Counter = 0;
        private void ADD_Hole_Btn_Click(object sender, EventArgs e)
        {
            H_Counter++;
            Allocate_Hole(Holes, Convert.ToInt32(starting_add_textBox.Text), Convert.ToInt32(holeSize_textBox.Text));
            H.Rows.Add(starting_add_textBox.Text, holeSize_textBox.Text);
            H_DataTable.DataSource = H;
            starting_add_textBox.Text = "";
            holeSize_textBox.Text = "";

            if (H_Counter == Convert.ToInt32(no_Holes_textBox.Text))
            {
                no_Holes_textBox.Enabled = false;
                starting_add_textBox.Enabled = false;
                holeSize_textBox.Enabled = false;
                ADD_Hole_Btn.Enabled = false;
            }
        }

        private void ADD_process_Btn_Click(object sender, EventArgs e)
        { 
            
            p_Counter++;
            string process_name = processName_textBox.Text;
            if(First_Fit_btn.Checked==true)
                 Allocate_Process(Holes, Convert.ToInt32(no_processes_textBox.Text), processes,frag, process_name, 
                 Convert.ToInt32(processSize_textBox.Text), 1);
            else if(Best_Fit_btn.Checked==true)
                 Allocate_Process(Holes, Convert.ToInt32(no_processes_textBox.Text), processes,frag, process_name, 
                 Convert.ToInt32(processSize_textBox.Text), 2);
            if (indicate)
            {
                MessageBox.Show("this process can't be allocated ,PLEASE deallocate one of the allocated processes!");
                p_Counter--;
            }
            else
            {
                P.Rows.Add(process_name, processSize_textBox.Text);
                P_DataTable.DataSource = P;
                if (frag_Counter > 0 && !flag_frag)
                {
                    F.Rows.Add(frag[frag.Count() - 1].allocated_Address, frag[frag.Count() - 1].frag_Size);
                    F_DataTable.DataSource = F;
                }
            }
            processName_textBox.Text = "";
            processSize_textBox.Text = "";

            if (p_Counter == Convert.ToInt32(no_processes_textBox.Text))
            {
                no_processes_textBox.Enabled = false;
                processName_textBox.Enabled = false;
                processSize_textBox.Enabled = false;
                ADD_process_Btn.Enabled = false;      
            }
        }

        private void Deallocate_Button_Click(object sender, EventArgs e)
        {
            p_Counter--;
            int global = 0;
            int frag_table = 0;
            no_processes_textBox.Enabled = true;
            processName_textBox.Enabled = true;
            processSize_textBox.Enabled = true;
            ADD_process_Btn.Enabled = true;
            de_Allocation(Holes, Convert.ToInt32(no_processes_textBox.Text), processes, frag, Deallocation_process_txBox.Text, ref global, ref frag_table);
            P.Rows.RemoveAt(global);
            if(frag.Count()>0)
                F.Rows.RemoveAt(frag_table);
            Deallocation_process_txBox.Text = "";
        }

        private void gannt ()
        {
            for (int i = 0; i < processes.Count(); i++)
            {
                process_Hole temp = new process_Hole();
                temp.Name = processes[i].Name;
                temp.Address = processes[i].allocating_Address;
                temp.Size = processes[i].p_Size;
                p_H.Add(temp);
            }
            for (int i = 0; i < frag.Count(); i++)
            {
                process_Hole temp = new process_Hole();
                temp.Name = frag[i].f_Name ;
                temp.Address = frag[i].allocated_Address;
                temp.Size = frag[i].frag_Size;
                p_H.Add(temp);
            }
            for (int i = 0; i < Holes.Count(); i++)
            {
                process_Hole temp = new process_Hole();
                temp.Name = Holes[i].Name ;
                temp.Address = Holes[i].starting_Address;
                temp.Size = Holes[i].hole_Size;
                p_H.Add(temp);
            }
            Sort_chart(p_H);
        }
        int counter = 0;
        private void Run_Btn_Click(object sender, EventArgs e)
        {
            counter++;
            p_H.Clear();
            gannt();
            DataTable chart_PH = new DataTable();
            chart_PH.Columns.Add("High");
            chart_PH.Columns.Add("Low");
            chart_PH.Columns.Add("Start");
            chart_PH.Columns.Add("End");
            chart_PH.Columns.Add("Name");
            for (int i = 0; i < p_H.Count; i++)
            {
                chart_PH.Rows.Add(1, 5, p_H[i].Address, p_H[i].Address + p_H[i].Size, p_H[i].Name);
            }     
            PH_chart.Series["Memory"].Color = Color.Green;
            PH_chart.Series["Memory"].YValueMembers = "High, Low, Start, End";
            PH_chart.Series["Memory"].XValueMember = "Name";
            PH_chart.Series["Memory"].XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Date;
            PH_chart.Series["Memory"]["ShowOpenClose"] = "Both";
            PH_chart.DataManipulator.IsStartFromFirst = true;
            PH_chart.DataSource = chart_PH;
            PH_chart.DataBind();

            if (counter > 1)
                R.Clear();
            
            for (int i = 0; i < p_H.Count(); i++)
            {
                R.Rows.Add(p_H[i].Address, p_H[i].Name, p_H[i].Size);
                Result_Table.DataSource = R;
            }
        }
    }
}
