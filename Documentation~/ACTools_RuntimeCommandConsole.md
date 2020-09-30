# ACTools: Debug Console
<br>

## Instructions
### How to use the console:
<ol>
	<li>
		<p>To open the console, press the grave accent key (`).</p>
	</li>
	<li>
		<p>Type "help" into the input field and press the enter/return key to display all of the available commands.</p>
	</li>
	<li>
		<p>You can click on the commands in the help window or in the suggestion window to have that command writing in the input field.</p>
	</li>
	<li>
		<p>Commands with <i>< parameter ></i> take in a value for the you to enter after you type a command into the input field. 
		Be sure to leave a single space between the command and the parameter.</p>
	</li>
</ol>
<hr/>

### How to create your own command:
<ol>
	<li>
		<p>Add <i>using ACTools.RuntimeCommandConsole</i> to the top of the file.</p>
	</li>
	<li>
		<p>Inside your <i>Start()</i> method, type Console.AddCommand.</p>
		<p>Below are the parameters for the Console.AddCommand and the Console.AddCommand<T1> method.</p>
		<ul>
			<li>
				<p>id - ID of the command. This is what the debug console is looking for.</p>
			</il>
			<li>
				<p>description - What the command does.</p>
			</il>
			<li>
				<p>format - How to write the command in the debub console.</p>
			</il>
			<li>
				<p>newCommand - The action that is called when the command is invoked.</p>
			</il>
		</ul>
		<p>Below are the types avalable for the Console.AddCommand<T1> method.</p>
		<ul>
			<li>
				string
			</il>
			<li>
				int
			</il>
			<li>
				float
			</il>
		</ul>
	</li>
	<li>
		<p>Below are examples of how commands can be written.</p>
		<ul>
			<li>
				CommandCollection.AddCommand("load_weapons_test_scene", "Loads the test scene for the weapons.", "load_weapons_test_scene", () => LevelLoader.LoadWeaponsScene()))
			</il>
			<li>
				CommandCollection.AddCommand<int>("set_ammo_count", "Sets the ammo count of your current weapon to the given value.", "set_ammo_count {value}", (value) => WeaponsManager.CurrentWeapon.AmmoCount = value))
			</il>
		</ul>
	</li>
</ol>
<hr/>
