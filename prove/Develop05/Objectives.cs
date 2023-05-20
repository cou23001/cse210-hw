using System;

public class Objectives
{
    private List<Goal> _objectives = new List<Goal>();
    private int _totalPoints = 0;

    public int Count() {
        return _objectives.Count;
    }

    public void Add(Goal goal)
    {
        _objectives.Add(goal);
    }
    public void SaveGoals(string filename) {

        if (File.Exists(filename)) {
            File.Delete(filename);
        }
        
        File.AppendAllText(filename,$"{TotalPoints()}\n");
        foreach (Goal goal in _objectives) {
            File.AppendAllText(filename, $"{goal.ToCSV()}\n");
        }
    }
    public int TotalPoints() {

        int total = _totalPoints;
        foreach (Goal goal in _objectives) {
            total = total + goal.GetTotalPoints();
        }
        return total;
    }

    public string DisplayGoals() {

        string output;
        
        if (_objectives.Count == 0) {
            output = "No goals found.";
            return output;
        }

        output = "";
        
        int cont = 1;
        foreach (Goal goal in _objectives) {
            char theX = ' ';
            if (goal.IsComplete())
                theX = 'X';
            output = output + $"{cont}. [{theX}] {goal.ToDisplay()} \n";
            cont++;
        }
        return output;
    }

    public string ShowGoals() {

        string output;
        
        if (_objectives.Count == 0) {
            output = "No goals found.";
            return output;
        }

        output = "";
        
        int cont = 1;
        foreach (Goal goal in _objectives) {
            output = output + $"{cont}. {goal.GetName()} \n";
            cont++;
        }
        return output;
    }

    public string LoadGoals(string filename) {
        
        if (!File.Exists(filename)) {
            return "No goals file found.";
        }

        _objectives.Clear();
        using (StreamReader reader = new StreamReader(filename))
        {
            string line;
            _totalPoints = int.Parse(reader.ReadLine());
            while ((line = reader.ReadLine()) != null)
            {
                string[] parts = line.Split(',');
                
                char goal_id = parts[0][0];
                string[] name_total = parts[0].Split(':');
                string name = name_total[1];
                string desc = parts[1];
                int amount = int.Parse(parts[2]);

                if (goal_id == 'S') {
                    bool complete = bool.Parse(parts[3]);
                    SimpleGoal sg = new SimpleGoal(name, desc, amount);
                    if (complete)
                        sg.SetComplete();
                    _objectives.Add(sg);
                }
                    
                else if (goal_id == 'E') {
                    _objectives.Add(new EternalGoal(name, desc, amount));
                }
                else if (goal_id == 'C') {
                    int bonus = int.Parse(parts[3]);
                    int times = int.Parse(parts[4]);
                    int timesCompleted = int.Parse(parts[5]);
                    CheckListGoal cg = new CheckListGoal(name, desc, amount, bonus, times);
                    cg.SetTimesCompleted(timesCompleted);
                    if (timesCompleted == times || timesCompleted > times)
                        cg.SetComplete();
                    _objectives.Add(cg);
                }
                else if (goal_id == 'N') {
                    bool complete = bool.Parse(parts[3]);
                    NegativeGoal ng = new NegativeGoal(name, desc, amount);
                    if (complete)
                        ng.SetComplete();
                    _objectives.Add(ng);
                }
            }
        }
        return $"Loaded {_objectives.Count} goals.\n";
    }

    public int RecordEvent(int goal_id)
    {
        Goal g = _objectives.ElementAt(goal_id - 1);
        return g.RecordEvent();                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                           
    }

    public bool NegativeGoalType(int goal_id)
    {
        Goal g = _objectives.ElementAt(goal_id - 1);
        if (g.ToCSV()[0].Equals('N'))
            return true;
        return false;
    }
}