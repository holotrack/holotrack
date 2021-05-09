// Copyright 2020 - 2021 Vignette Project
// Licensed under NPOSLv3. See LICENSE for details.

using NUnit.Framework;
using Vignette.Game.Screens.Menu;

namespace Vignette.Game.Tests.Visual.Screens
{
    public class TestSceneMainMenu : ScreenTestScene
    {
        private MainMenu menu;

        public override void SetupSteps()
        {
            base.SetupSteps();
            AddStep("load main menu", () => LoadScreen(menu = new MainMenu()));
        }

        [Test]
        public void TestMenuNavigationControls()
        {
            AddStep("toggle side panel", () => Schedule(() => menu.ToggleNavigationView()));
            AddStep("select help tab", () => Schedule(() => menu.SelectTab(typeof(HelpScreen))));
        }
    }
}
