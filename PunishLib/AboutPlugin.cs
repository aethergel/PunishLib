using Dalamud.Interface;
using Dalamud.Interface.Colors;
using ImGuiNET;
using PunishLib.ImGuiMethods;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PunishLib
{
    public class AboutPlugin
    {
        public string Sponsor { get; set; }
        public string Developer { get; set; }

        internal Action WithLoveBy => Developer == null ? WithLoveByPunish : WithLoveByOther;

        static void WithLoveByPunish()
        {
            ImGuiEx.ImGuiLineCentered("AboutHeader", delegate
            {
                ImGuiEx.Text($"Puni.sh가 ");
                ImGui.PushFont(UiBuilder.IconFont);
                ImGui.SameLine(0, 0);
                ImGuiEx.Text(ImGuiColors.DalamudRed, FontAwesomeIcon.Heart.ToIconString());
                ImGui.PopFont();
                ImGui.SameLine(0, 0);
                ImGuiEx.Text($" 와 함께 개발하고 배포합니다");
            });
        }

        static void WithLoveByOther()
        {
            //Developed with ❤️ by {Developer}, published by Puni.sh
            ImGuiEx.ImGuiLineCentered("AboutHeader", delegate
            {
                ImGuiEx.Text($"{PunishLibMain.About.Developer}가 ");
                ImGui.PushFont(UiBuilder.IconFont);
                ImGui.SameLine(0, 0);
                ImGuiEx.Text(ImGuiColors.DalamudRed, FontAwesomeIcon.Heart.ToIconString());
                ImGui.PopFont();
                ImGui.SameLine(0, 0);
                ImGuiEx.Text($" 와 함께 개발하고, Puni.sh가 배포합니다");
            });
        }
    }

}
