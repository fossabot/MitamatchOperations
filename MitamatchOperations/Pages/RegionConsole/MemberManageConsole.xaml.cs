using System.Collections.Generic;
using System.Collections.ObjectModel;
using mitama.Domain;
using mitama.Pages.Common;
using System.Linq;
using Microsoft.UI.Xaml.Navigation;
using WinRT;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml;
using mitama.Pages.OrderConsole;
using System.IO;
using System.Text;
using System.Text.Json;
using Microsoft.UI.Text;
using System;
using mitama.Pages.Main;

namespace mitama.Pages.RegionConsole;

/// <summary>
/// An empty page that can be used on its own or navigated to within a Frame.
/// </summary>
public sealed partial class MemberManageConsole
{
    private string _regionName = Director.ReadCache().Region;
    private string opponent;
    private string chara1;
    private string chara2;
    private string skill1;
    private string skill2;
    private string personnel1;
    private string personnel2;
    private string tatic1;
    private string tatic2;
    private List<TimeTableItem> timeline;
    private readonly ObservableCollection<MemberInfo> _members = [];

    public MemberManageConsole()
    {
        InitializeComponent();
        NavigationCacheMode = NavigationCacheMode.Enabled;
        Init();
    }

    private void Update()
    {
        _regionName = Director.ReadCache().Region;
        _members.Clear();
        foreach (var item in from item in Util.LoadMembersInfo(_regionName)
                             orderby item.Position
                             select item)
        {
            _members.Add(item);
        }
    }

    private void Init()
    {
        _regionName = Director.ReadCache().Region;
        foreach (var item in from item in Util.LoadMembersInfo(_regionName)
                             orderby item.Position
                             select item)
        {
            _members.Add(item);
        }
    }

    private void Opponent_TextChanged(object sender, TextChangedEventArgs _)
    {
        OpponentSettings.Description = opponent = sender.As<TextBox>().Text;
    }

    private void RareSkill_Loaded(object sender, RoutedEventArgs _)
    {
        sender.As<ComboBox>().ItemsSource = Costume.List.Select(x => x.Lily).Distinct();
    }

    private void ComboBox1_SelectionChanged(object sender, SelectionChangedEventArgs _)
    {
        chara1 = sender.As<ComboBox>().SelectedItem.As<string>();
        Skill1.ItemsSource = Costume.List.Where(x => x.Lily == chara1).Select(x => x.RareSkill.Name).Distinct();
    }

    private void ComboBox2_SelectionChanged(object sender, SelectionChangedEventArgs _)
    {
        chara2 = sender.As<ComboBox>().SelectedItem.As<string>();
        Skill2.ItemsSource = Costume.List.Where(x => x.Lily == chara2).Select(x => x.RareSkill.Name).Distinct();
    }

    private void Skill1_SelectionChanged(object sender, SelectionChangedEventArgs _)
    {
        skill1 = sender.As<ComboBox>().SelectedItem.As<string>();
        if (chara2 is not null && skill2 is not null)
        {
            RareSkillSettings.Description = $"{chara1}({skill1}) / {chara2}({skill2})";
        }
        else
        {
            RareSkillSettings.Description = $"{chara1}({skill1})";
        }
    }

    private void Skill2_SelectionChanged(object sender, SelectionChangedEventArgs _)
    {
        skill2 = sender.As<ComboBox>().SelectedItem.As<string>();
        if (chara1 is not null && skill1 is not null)
        {
            RareSkillSettings.Description = $"{chara1}({skill1}) / {chara2}({skill2})";
        }
        else
        {
            RareSkillSettings.Description = $"{chara2}({skill2})";
        }
    }

    private void Personnel1_SelectionChanged(object sender, SelectionChangedEventArgs _)
    {
        personnel1 = sender.As<ComboBox>().SelectedItem.As<string>();
    }

    private void Personnel2_SelectionChanged(object sender, SelectionChangedEventArgs _)
    {
        personnel2 = sender.As<ComboBox>().SelectedItem.As<string>();
    }

    private void Personnel_Loaded(object sender, RoutedEventArgs _)
    {
        sender.As<ComboBox>().ItemsSource = Util.LoadMembersInfo(_regionName).Select(x => x.Name);
    }

    private void Timeline_Loaded(object sender, RoutedEventArgs _)
    {
        if (sender is not ComboBox box) return;

        if (!Directory.Exists(Director.DeckDir(_regionName)))
        {
            Director.CreateDirectory(Director.DeckDir(_regionName));
        }
        var decks = Directory.GetFiles(Director.DeckDir(_regionName), "*.json").Select(path =>
        {
            using var sr = new StreamReader(path, Encoding.GetEncoding("UTF-8"));
            var json = sr.ReadToEnd();
            return JsonSerializer.Deserialize<DeckJson>(json);
        }).ToList();

        box.ItemsSource = decks;
    }

    private void Tactic1_SelectionChanged(object sender, SelectionChangedEventArgs _)
    {
        string[] v = ["単体", "範囲"];
        tatic1 = v[sender.As<ComboBox>().SelectedIndex];
        if (tatic2 is not null)
        {
            NauntWeltSettings.Description = $"{tatic1} / {tatic2}";
        }
        else
        {
            NauntWeltSettings.Description = $"{tatic1}";
        }
    }

    private void Tactic2_SelectionChanged(object sender, SelectionChangedEventArgs _)
    {
        string[] v = ["支援", "妨害", "回復"];
        tatic2 = v[sender.As<ComboBox>().SelectedIndex];
        if (tatic1 is not null)
        {
            NauntWeltSettings.Description = $"{tatic1} / {tatic2}";
        }
        else
        {
            NauntWeltSettings.Description = $"{tatic2}";
        }
    }

    private void Timeline_SelectionChanged(object sender, SelectionChangedEventArgs e)
    {
        if (sender is not ComboBox box) return;
        if (box.SelectedItem is not DeckJson deck) return;

        timeline = [.. deck.Items];
        TimelineSettings.Description = deck.Name;
    }

    private void HyperlinkButton_Click(object sender, RoutedEventArgs e)
    {
        if (opponent == null) return;
        if (chara1 == null) return;
        if (chara2 == null) return;
        if (skill1 == null) return;
        if (skill2 == null) return;
        if (personnel1 == null) return;
        if (personnel2 == null) return;
        if (tatic1 == null) return;
        if (tatic2 == null) return;
        if (timeline == null) return;

        var kousei = "";
        kousei += Normal.SelectedIndex == 0 ? "" : $"通常{Normal.SelectedIndex} ";
        kousei += Special.SelectedIndex == 0 ? "" : $"特殊{Special.SelectedIndex} ";
        kousei += Both.SelectedIndex == 0 ? "" : $"両刀{Both.SelectedIndex} ";

        var order = string.Join("\n", (new string[] {
            $"{timeline[0].Order.Name}: {timeline[0].Pic}"
        }).Concat(timeline.Skip(1).Select(x => x switch
        {
            _ when x.Conditional => @$"{x.Order.Name}: {x.Pic}（予備）",
            _ => $"↓\n{x.Order.Name}: {x.Pic}",
        })));

        Remarks.Document.GetText(TextGetOptions.UseCrlf, out var remarks);

        var text = $"""
            # {opponent}({kousei})

            ## Rare Skills

            ```
            - {chara1}:{skill1} ⇒ {personnel1}
            - {chara2}:{skill2} ⇒ {personnel2}
            ```

            ## Neun Welt

            ```
            - {tatic1}/{tatic2}
            ```

            ## Timeline

            ```
            {order}
            ```
        """;
        if (remarks != "")
        {
            text += $"""

                ## Remarks

                ```
                {remarks}
                ```
            """;
        }
        System.Windows.Clipboard.SetText(text);
    }

    private async void Delete_Click(object sender, RoutedEventArgs e)
    {
        var toDelete = sender.As<MenuFlyoutItem>().AccessKey;
        // dialog forward definition
        var dialog = new DialogBuilder(XamlRoot)
            .WithTitle("本当におわかれしますか？")
            .WithPrimary("おわかれする")
            .WithCancel("やっぱりやめる")
            .Build();

        // ReSharper disable once AsyncVoidLambda
        dialog.PrimaryButtonCommand = new Defer(delegate {
            new DirectoryInfo($@"{Director.ProjectDir()}\{_regionName}\Members\{toDelete}").Delete(true);
            Update();
            return System.Threading.Tasks.Task.CompletedTask;
        });
        await dialog.ShowAsync();
    }

    private async void AddMember_OnClick(object sender, RoutedEventArgs e)
    {
        var dialog = new DialogBuilder(XamlRoot)
            .WithTitle("レギオンメンバを追加します")
            .WithPrimary("Add")
            .WithCancel("Cancel")
            .Build();
        dialog.IsPrimaryButtonEnabled = false;

        string name = null;
        Position position = null;

        var body = new AddNewMemberDialogContent(fragment =>
        {
            switch (fragment)
            {
                case NewMemberName(var s):
                    name = s;
                    break;
                case NewMemberPosition(var p):
                    position = p;
                    break;
            }
            if (name != null && position != null) dialog.IsPrimaryButtonEnabled = true;
        });

        dialog.Content = body;
        dialog.PrimaryButtonCommand = new Defer(delegate {
            Director.CreateDirectory($@"{Director.ProjectDir()}\{_regionName}\Members\{name}");
            Director.CreateDirectory($@"{Director.ProjectDir()}\{_regionName}\Members\{name}\Units");
            var fs = File.Create($@"{Director.ProjectDir()}\{_regionName}\Members\{name}\info.json");
            var memberJson = new MemberInfo(DateTime.Now, DateTime.Now, name!, position!, [], []).ToJson();
            var save = new UTF8Encoding(true).GetBytes(memberJson);
            fs.Write(save, 0, save.Length);
            fs.Close();
            Update();
            return System.Threading.Tasks.Task.CompletedTask;
        });

        await dialog.ShowAsync();
    }
}

// GroupInfoList class definition:
internal class GroupInfoList(IEnumerable<MemberInfo> items) : List<MemberInfo>(items)
{
    public object Key { get; set; } = null!;
}
