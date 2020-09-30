## ACTools: Runtime Command Console
<p>
    This debug console is based on Game Dev Guide's Debug Cheat Console: https://www.youtube.com/watch?v=VzOEM-4A2OM&t=0s.
<p>
    This runtime command console tool is for developers to create commands to can use during the game to make it easier to debug and test the game.
    <br/>
    Feel free to use it for whatever. If you wouldn't mind, please credit me. It would be appreciated!
</p>

## Installation:
<p>
    <b>For easy updates, use the following git URL through the Package Manager: https://github.com/mob-sakai/UpmGitExtension.git</b>
    <br/>
    <i>&nbsp;&nbsp;&nbsp;&nbsp;I guess you could use a submodule as well, but I can't help you with that.</i>
</p>
<p>
    <b>In the Package Manager, use the following git URL: https://github.com/Cpt-Jack04/ACTools_RuntimeCommandConsole.git</b>
    <br/>
    <br/>
    In the Unity Editor, go to Tools>ACTools>Runtime Command Console>Initialize Console. Click the "Generate Required Folders" button, wait for the folders to be generated, then click the "Generate Required Assets".
    <br/>
    <br/>
    In the Project Window, navigate to Assets/Resources/ACTools/Prefabs and open the Console Canvas Prefab there. Open the "Events" dropdown and open the "Command Map" dropdown.
    <br/>
    <br/>
    With the Console Canvas Prefab still open, navigate to Assets/Resources/ACTools/ScriptableObjects. You will need to add some listeners from the Console Controller to a few events.
</p>
<ol>
    <li>In the "Toggle Console" event, add the "Console Controller" ScriptableObject. Then select the "CreateOrToggleConsole" method as the function.</li>
    <li>In the "Submit" event, add the "Console Controller" ScriptableObject. Then select the "OnSubmit" method as the function.</li>
    <li>In the "Select Input Field" event, add the "Console Controller" ScriptableObject. Then select the "SelectInputField" method as the function.</li>
</ol>
<p>
    To open the console, press the grave accent key (`).
</p>

<p>
  If you need to get in touch with me, please email me or @ me on Twitter. You can find those on my profile on GitHub. If you feel like supporting me, click the button down below.
</p>

<a href="https://www.buymeacoffee.com/alexcline" target="_blank"><img src="https://cdn.buymeacoffee.com/buttons/v2/default-violet.png" alt="Buy Me A Coffee" style="height: 7.5px !important;width: 27.13px !important;" ></a>

[!INCLUDE [<ACTools_RuntimeCommandConsole>](</Documentation~/ACTools_RuntimeCommandConsole.md>)]
