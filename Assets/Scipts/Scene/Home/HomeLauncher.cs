using Agate.MVC.Base;
using Agate.MVC.Core;
using ExampleGame.Boot;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ExampleGame.Home
{
    public class HomeLauncher : SceneLauncher<HomeLauncher, HomeView>
    {
        public override string SceneName => "Home";

        private void OnClickPlayButton()
        {
            SceneLoader.Instance.LoadScene("Gameplay");
        }

        protected override IConnector[] GetSceneConnectors()
        {
            return null;
        }

        protected override IController[] GetSceneDependencies()
        {
            return null;
        }

        protected override IEnumerator InitSceneObject()
        {
            _view.SetCallbacks(OnClickPlayButton);
            yield return null;
        }

        protected override IEnumerator LaunchScene()
        {
            yield return null;
        }
    }
}
