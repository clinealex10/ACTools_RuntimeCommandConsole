# ACTools: Core
<br>

## Custom Attributes
### Read Only
<p>This attribute disables the serialized field it is attact to, making it appear in the inspect but making it impossible to edit in the inspector.
<br>
<hr/>

## Events
### Custom UnityEvents
<ul>
	<li>
		public class StringEvent : UnityEvent<string>
	</li>
	<li>
		<p>public class BoolEvent : UnityEvent<bool></p>
	</li>
	<li>
		<p>public class IntEvent : UnityEvent<int></p>
	</li>
	<li>
		<p>public class FloatEvent : UnityEvent<float></p>
	</li>
</ul>
<br>
<hr/>

### public class GameEvent : ScriptableObject
<ul>
	<li> Fields
		<ul>
			<li>
				<p>protected List&lt;GameEventListener&gt; listeners</p>
				<p>Holds a collection of listeners to this GameEvent.</p>
			</li>
		</ul>
	</li>
	<li> Methods
		<ul>
			<li>
				<p>public virtual void Register(GameEventListener listener)</p>
				<p>Adds a listener to this GameEvent.</p>
				<p>listener: Listener to add.</p>
			</li>
			<li>
				<p>public virtual void Unregister(GameEventListener listener)</p>
				<p>Removes a listener to this GameEvent.</p>
				<p>listener: Listener to remove.</p>
			</li>
			<li>
				<p>public virtual void Invoke()</p>
				<p>Invokes this GameEvent.</p>
			</li>
		</ul>
	</li>
</ul>
<br>
<hr/>

### public class GameEvent_String : ScriptableObject
<ul>
	<li> Fields
		<ul>
			<li>
				<p>protected List&lt;GameEventListener_String&gt; listeners</p>
				<p>Holds a collection of listeners to this GameEvent.</p>
			</li>
		</ul>
	</li>
	<li> Methods
		<ul>
			<li>
				<p>public virtual void Register(GameEventListener_String listener)</p>
				<p>Adds a listener to this GameEvent.</p>
				<p>listener: Listener to add.</p>
			</li>
			<li>
				<p>public virtual void Unregister(GameEventListener_String listener)</p>
				<p>Removes a listener to this GameEvent.</p>
				<p>listener: Listener to remove.</p>
			</li>
			<li>
				<p>public virtual void Invoke(string argument)</p>
				<p>Invokes this GameEvent.</p>
				<p>argument: Argument to pass through from the event.</p>
			</li>
		</ul>
	</li>
</ul>
<br>
<hr/>

### public class GameEvent_Bool : ScriptableObject
<ul>
	<li> Fields
		<ul>
			<li>
				<p>protected List&lt;GameEventListener_Bool&gt; listeners</p>
				<p>Holds a collection of listeners to this GameEvent.</p>
			</li>
		</ul>
	</li>
	<li> Methods
		<ul>
			<li>
				<p>public virtual void Register(GameEventListener_Bool listener)</p>
				<p>Adds a listener to this GameEvent.</p>
				<p>listener: Listener to add.</p>
			</li>
			<li>
				<p>public virtual void Unregister(GameEventListener_Bool listener)</p>
				<p>Removes a listener to this GameEvent.</p>
				<p>listener: Listener to remove.</p>
			</li>
			<li>
				<p>public virtual void Invoke(bool argument)</p>
				<p>Invokes this GameEvent.</p>
				<p>argument: Argument to pass through from the event.</p>
			</li>
		</ul>
	</li>
</ul>
<br>
<hr/>

### public class GameEvent_Int : ScriptableObject
<ul>
	<li> Fields
		<ul>
			<li>
				<p>protected List&lt;GameEventListener_Int&gt; listeners</p>
				<p>Holds a collection of listeners to this GameEvent.</p>
			</li>
		</ul>
	</li>
	<li> Methods
		<ul>
			<li>
				<p>public virtual void Register(GameEventListener_Int listener)</p>
				<p>Adds a listener to this GameEvent.</p>
				<p>listener: Listener to add.</p>
			</li>
			<li>
				<p>public virtual void Unregister(GameEventListener_Int listener)</p>
				<p>Removes a listener to this GameEvent.</p>
				<p>listener: Listener to remove.</p>
			</li>
			<li>
				<p>public virtual void Invoke(int argument)</p>
				<p>Invokes this GameEvent.</p>
				<p>argument: Argument to pass through from the event.</p>
			</li>
		</ul>
	</li>
</ul>
<br>
<hr/>

### public class GameEvent_Float : ScriptableObject
<ul>
	<li> Fields
		<ul>
			<li>
				<p>protected List&lt;GameEventListener_Float&gt; listeners</p>
				<p>Holds a collection of listeners to this GameEvent.</p>
			</li>
		</ul>
	</li>
	<li> Methods
		<ul>
			<li>
				<p>public virtual void Register(GameEventListener_Float listener)</p>
				<p>Adds a listener to this GameEvent.</p>
				<p>listener: Listener to add.</p>
			</li>
			<li>
				<p>public virtual void Unregister(GameEventListener_Float listener)</p>
				<p>Removes a listener to this GameEvent.</p>
				<p>listener: Listener to remove.</p>
			</li>
			<li>
				<p>public virtual void Invoke(float argument)</p>
				<p>Invokes this GameEvent.</p>
				<p>argument: Argument to pass through from the event.</p>
			</li>
		</ul>
	</li>
</ul>
<br>
<hr/>

### public class GameEventListener : Monobehaviour
<ul>
	<li> Fields
		<ul>
			<li>
				<p>protected GameEvent gameEvent</p>
				<p>GameEvent to listen to.</p>
			</li>
		</ul>
		<ul>
			<li>
				<p>public UnityEvent Response</p>
				<p>Set of responses when the GameEvent is invoked.</p>
			</li>
		</ul>
	</li>
	<li> Methods
		<ul>
			<li>
				<p>public virtual void OnEventRaised()</p>
				<p>Method called when the event is invoked to invoke the Responses.</p>
			</li>
		</ul>
	</li>
</ul>
<br>
<hr/>

### public class GameEventListener_String : Monobehaviour
<ul>
	<li> Fields
		<ul>
			<li>
				<p>protected GameEvent_String gameEvent</p>
				<p>GameEvent to listen to.</p>
			</li>
		</ul>
		<ul>
			<li>
				<p>public StringEvent Response</p>
				<p>Set of responses when the GameEvent is invoked.</p>
			</li>
		</ul>
	</li>
	<li> Methods
		<ul>
			<li>
				<p>public virtual void OnEventRaised(string argument)</p>
				<p>Method called when the event is invoked to invoke the Responses.</p>
				<p>argument: Argument to pass through from the event.</p>
			</li>
		</ul>
	</li>
</ul>
<br>
<hr/>

### public class GameEventListener_Bool : Monobehaviour
<ul>
	<li> Fields
		<ul>
			<li>
				<p>protected GameEvent_Bool gameEvent</p>
				<p>GameEvent to listen to.</p>
			</li>
		</ul>
		<ul>
			<li>
				<p>public BoolEvent Response</p>
				<p>Set of responses when the GameEvent is invoked.</p>
			</li>
		</ul>
	</li>
	<li> Methods
		<ul>
			<li>
				<p>public virtual void OnEventRaised(bool argument)</p>
				<p>Method called when the event is invoked to invoke the Responses.</p>
				<p>argument: Argument to pass through from the event.</p>
			</li>
		</ul>
	</li>
</ul>
<br>
<hr/>

### public class GameEventListener_Int : Monobehaviour
<ul>
	<li> Fields
		<ul>
			<li>
				<p>protected GameEvent_Int gameEvent</p>
				<p>GameEvent to listen to.</p>
			</li>
		</ul>
		<ul>
			<li>
				<p>public IntEvent Response</p>
				<p>Set of responses when the GameEvent is invoked.</p>
			</li>
		</ul>
	</li>
	<li> Methods
		<ul>
			<li>
				<p>public virtual void OnEventRaised(int argument)</p>
				<p>Method called when the event is invoked to invoke the Responses.</p>
				<p>argument: Argument to pass through from the event.</p>
			</li>
		</ul>
	</li>
</ul>
<br>
<hr/>

### public class GameEventListener_Float : Monobehaviour
<ul>
	<li> Fields
		<ul>
			<li>
				<p>protected GameEvent_Float gameEvent</p>
				<p>GameEvent to listen to.</p>
			</li>
		</ul>
		<ul>
			<li>
				<p>public FloatEvent Response</p>
				<p>Set of responses when the GameEvent is invoked.</p>
			</li>
		</ul>
	</li>
	<li> Methods
		<ul>
			<li>
				<p>public virtual void OnEventRaised(float argument)</p>
				<p>Method called when the event is invoked to invoke the Responses.</p>
				<p>argument: Argument to pass through from the event.</p>
			</li>
		</ul>
	</li>
</ul>
<br>
<hr/>

## Extension Methods
### Color Extensions
<ul>
	<li>
		<p>public void ChangeAlphaTo(float alphaValue)</p>
		<p>Changes the alpha value of this color to a given value.</p>
		<p>alphaValue: The alpha value this color will receive.</p>
	</li>
	<li>
		<p>public string ToHex()</p>
		<p>Gives the hex code of a color.</p>
		<p>Returns: The hex code of this color.</p>
	</li>
</ul>
<hr/>

### Debug Extensions
<p><b>Note: As there is no Debug object to extend, all of the Debug extension methods are in a public static class called <i>DebugExtensions</i>.<b></p>
<ul>
	<li>
		<p>public static void DrawQuadrilateral(Vector3 leftBottom, Vector3 rightBottom, Vector3 leftTop, Vector3 rightTop, Color color, float duration, bool depthTest)</p>
		<p>Draws a 4-sided 2D shape in 3D space.</p>
		<p>leftBottom: Bottom left corner of the shape.</p>
		<p>rightBottom: Bottom right corner of the shape.</p>
		<p>leftTop: Top left corner of the shape.</p>
		<p>rightTop: Top right corner of the shape.</p>
		<p>color: Color of the shape.</p>
		<p>duration: How long for the shape be visible for?</p>
		<p>depthTest: Should the shape be obscured by objects closer to the camera?</p>
	</li>
	<li>
		<p>public static void DrawRect(Vector3 leftBottom, Vector3 rightTop, float z, Color color, float duration, bool depthTest)</p>
		<p>Draws a rectangle. Only works in 2D space along the z axis.</p>
		<p>leftBottom: Bottom left corner of the shape.</p>
		<p>rightTop: Top right corner of the shape.</p>
		<p>z: Z value for the rectangle.</p>
		<p>color: Color of the shape.</p>
		<p>duration: How long for the shape be visible for?</p>
		<p>depthTest: Should the shape be obscured by objects closer to the camera?</p>
	</li>
	<li>
		<p>public static void DrawRectPrism(Vector3 leftBottomBack, Vector3 rightTopFront, Color color, float duration, bool depthTest)</p>
		<p>Draws a rectangular prism.</p>
		<p>leftBottomBack: Bottom left back corner of the shape.</p>
		<p>rightTopFront: Top right front corner of the shape.</p>
		<p>color: Color of the shape.</p>
		<p>duration: How long for the shape be visible for?</p>
		<p>depthTest: Should the shape be obscured by objects closer to the camera?</p>
	</li>
	<li>
		<p>public static void DrawCube(Vector3 center, float length, Color color, float duration, bool depthTest)</p>
		<p>Draws a cube.</p>
		<p>center: Center point of the shape.</p>
		<p>length: Length of any edge of the shape.</p>
		<p>color: Color of the shape.</p>
		<p>duration: How long for the shape be visible for?</p>
		<p>depthTest: Should the shape be obscured by objects closer to the camera?</p>
	</li>
</ul>
<hr/>
	
### NavMesh Agent Extensions
<ul>
	<li>
		<p>public NavMeshPath GetPathTo(Vector3 endPosition, int passableMask)</p>
		<p>Gets the NavMeshPath from this agent to a given point without setting the NavMeshPath of this NavMeshAgent.</p>
		<p>endPosition: Where the path ends.</p>
		<p>passableMask: A bitfield mask specifying which NavMesh areas can be passed when calculating a path.</p>
		<p>Returns: The path from one point to another if it was created. If it wasn't created, this will return null.</p>
	</li>
</ul>
<hr/>

### NavMesh Path Extensions
<p><b>Note: Some of the methods here were found in a post on this forum: <i>https://forum.unity.com/threads/getting-the-distance-in-nav-mesh.315846/</i>.<b></p>
<ul>
	<li>
		<p>public float GetPathLength()</p>
		<p>Gets the length of this path.</p>
		<p>Returns: The length of the path.</p>
	</li>
	<li>
		<p>public float GetPathLength(bool drawDeBugPath)</p>
		<p>Gets the length of this path.</p>
		<p>drawDeBugPath: Should this path be drawn using DeBug.DrawLine?</p>
		<p>Returns: The length of the path.</p>
	</li>
	<li>
		<p>public NavMeshPath GetPathTo(Vector3 startPosition, Vector3 endPosition, int passableMask)</p>
		<p>Gets the NavMeshPath from one given point to a second given point without setting this NavMeshPath.</p>
		<p>startPosition: Where the path begins.</p>
		<p>endPosition: Where the path ends.</p>
		<p>passableMask: A bitfield mask specifying which NavMesh areas can be passed when calculating a path.</p>
		<p>Returns: The path from one point to another if it was created. If it wasn't created, this will return null.</p>
	</li>
	<li>
		<p>public bool SetPathTo(Vector3 startPosition, Vector3 endPosition, int passableMask)</p>
		<p>Sets this NavMeshPath for a path from one given point to a second given point.</p>
		<p>startPosition: Where the path begins.</p>
		<p>endPosition: Where the path ends.</p>
		<p>passableMask: A bitfield mask specifying which NavMesh areas can be passed when calculating a path.</p>
		<p>Returns: True if the path is created.</p>
	</li>
</ul>
<hr/>
	
### Transform Extensions
<ul>
	<li>
		<p>public Vector3 DirectionTo(Transform destination)</p>
		<p>Finds the normalized direction from this Transform to a given Transform.</p>
		<p>destination: The Transform to be compared to this for the direction.</p>
		<p>Returns: The normalized Vector3 of the direction to the target.</p>
	</li>
	<li>
		<p>public bool IsBetween(Transform bottomLeftBack, Transform topRightFront)</p>
		<p>Checks to see if this Transform is between two other Transforms along all 3 axes.</p>
		<p>bottomLeftBack: One of the Transforms to compare to this.</p>
		<p>topRightFront: The other Transform to compare to this.</p>
		<p>Returns: True if this Transform is between the other two.</p>
	</li>
</ul>
<hr/>

### Vector2 Extensions
<ul>
	<li>
		<p>public bool AreAllValuesEqual()</p>
		<p>Checks the all the values to see if they're equal.</p>
		<p>Returns: True if all values are equal.</p>
	</li>
	<li>
		<p>public Vector2 DirectionTo(Vector2 destination)</p>
		<p>Finds the normalized direction from this Vector2 to a given Vector2.</p>
		<p>destination: The Vector2 to be compared to this for the direction.</p>
		<p>Returns: The normalized Vector2 of the direction to the target.</p>
	</li>
	<li>
		<p>public void FlatX()</p>
		<p>Sets the X value of this Vector2 to 0.</p>
	</li>
	<li>
		<p>public void FlatY()</p>
		<p>Sets the Y value of this Vector2 to 0.</p>
	</li>
	<li>
		<p>public bool IsBetween(Vector2 bottomLeft, Vector2 topRight)</p>
		<p>Checks to see if this Vector2 is between two other Vector2s along both axes.</p>
		<p>bottomLeft: One of the Vector2 to compare to this.</p>
		<p>topRight: The other Vector2 to compare to this.</p>
		<p>Returns: True if this Vector2 is between the other two.</p>
	</li>
	<li>
		<p>public void With(float? x = null, float? y = null)</p>
		<p>Replaces the current values of this Vector2 with any given values.</p>
		<p>x: The value to replace this Vector2.x, if any.</p>
		<p>y: The value to replace this Vector2.y, if any.</p>
	</li>
</ul>
<hr/>

### Vector3 Extensions
<ul>
	<li>
		<p>public bool AreAllValuesEqual()</p>
		<p>Checks the all the values to see if they're equal.</p>
		<p>Returns: True if all values are equal.</p>
	</li>
	<li>
		<p>public Vector3 DirectionTo(Vector3 destination)</p>
		<p>Finds the normalized direction from this Vector3 to a given Vector3.</p>
		<p>destination: The Vector3 to be compared to this for the direction.</p>
		<p>Returns: The normalized Vector3 of the direction to the target.</p>
	</li>
	<li>
		<p>public void FlatX()</p>
		<p>Sets the X value of this Vector3 to 0.</p>
	</li>
	<li>
		<p>public void FlatY()</p>
		<p>Sets the Y value of this Vector3 to 0.</p>
	</li>
	<li>
		<p>public void FlatZ()</p>
		<p>Sets the Z value of this Vector3 to 0.</p>
	</li>
	<li>
		<p>public bool IsBetween(Vector3 bottomLeftBack, Vector3 topRightFront)</p>
		<p>Checks to see if this Vector3 is between two other Vector3s along both axes.</p>
		<p>bottomLeftBack: One of the Vector3 to compare to this.</p>
		<p>topRightFront: The other Vector3 to compare to this.</p>
		<p>Returns: True if this Vector3 is between the other two.</p>
	</li>
	<li>
		<p>public void With(float? x = null, float? y = null, float? z = null)</p>
		<p>Replaces the current values of this Vector3 with any given values.</p>
		<p>x: The value to replace this Vector3.x, if any.</p>
		<p>y: The value to replace this Vector3.y, if any.</p>
		<p>z: The value to replace this Vector3.z, if any.</p>
	</li>
</ul>
<hr/>

### VisualElement Extensions
<ul>
	<li>
		<p>public void VisualElementSetup<T>(string name, string ussClass) where T : VisualElement</p>
		<p>Sets up this visual element's name and class.</p>
		<p>T: Type of this visual element.</p>
		<p>name: Name of this visual element.</p>
		<p>ussClass: Class to add to this visual element.</p>
	</li>
	<li>
		<p>public void VisualElementSetup<T>(string name, string[] ussClasses) where T : VisualElement</p>
		<p>Sets up this visual element's name and class.</p>
		<p>T: Type of this visual element.</p>
		<p>name: Name of this visual element.</p>
		<p>ussClasses: Classes to add to this visual element.</p>
	</li>
</ul>
<hr/>

## Utility
### public static class CompareObjects
<ul>
	<li>
		<p>public static int ByName<T>(T x, T y) where T : Object</p>
		<p>Compares two objects based on their names.</p>
		<p>T: The types of objects being compared.</p>
		<p>x: One of the objects to be compared.</p>
		<p>y: The other object to be compared.</p>
		<p>Returns: Zero if they are equal, a negative number if x precedes y, a positive number if x comes after y.</p>
	</li>
</ul>
<hr/>
