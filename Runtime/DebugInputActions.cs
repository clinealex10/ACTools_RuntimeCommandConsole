// GENERATED AUTOMATICALLY FROM 'Assets/ACTools_DebugConsole/Runtime/DebugInputActions.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

namespace ACTools.DebugConsole
{
    public class @DebugInputActions : IInputActionCollection, IDisposable
    {
        public InputActionAsset asset { get; }
        public @DebugInputActions()
        {
            asset = InputActionAsset.FromJson(@"{
    ""name"": ""DebugInputActions"",
    ""maps"": [
        {
            ""name"": ""Debug"",
            ""id"": ""568ecf9a-1a6d-409f-8276-a2328a2bef65"",
            ""actions"": [
                {
                    ""name"": ""Navigate"",
                    ""type"": ""Value"",
                    ""id"": ""fb127277-21ad-410e-b71b-2552f826fd66"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Submit"",
                    ""type"": ""Button"",
                    ""id"": ""88510871-8685-4144-84fb-248a2fc4b937"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Cancel"",
                    ""type"": ""Button"",
                    ""id"": ""f238267e-3f7c-48ff-bce5-66c673e90f82"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Point"",
                    ""type"": ""PassThrough"",
                    ""id"": ""669e2840-094c-4396-8d04-bb468be9909f"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Click"",
                    ""type"": ""PassThrough"",
                    ""id"": ""c8ba4cc8-3a23-4a4b-88f7-0cbecf8e67e6"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""ScrollWheel"",
                    ""type"": ""PassThrough"",
                    ""id"": ""59d9e80c-e001-4f4c-b286-42cb54fad2a0"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""MiddleClick"",
                    ""type"": ""PassThrough"",
                    ""id"": ""64106052-bae5-45c2-abeb-e8f1236cd5fb"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""RightClick"",
                    ""type"": ""PassThrough"",
                    ""id"": ""df045ea1-f89b-4756-879e-0ad8f7a61057"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""TrackedDevicePosition"",
                    ""type"": ""PassThrough"",
                    ""id"": ""dd57a088-ba59-4552-b20b-51ec82401f11"",
                    ""expectedControlType"": ""Vector3"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""TrackedDeviceOrientation"",
                    ""type"": ""PassThrough"",
                    ""id"": ""ec193b5e-0cdc-4998-a881-fad9cca6621d"",
                    ""expectedControlType"": ""Quaternion"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Toggle Console"",
                    ""type"": ""Button"",
                    ""id"": ""c02496c7-5047-4ac8-a360-60f4e2794845"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Select Input Field"",
                    ""type"": ""Button"",
                    ""id"": ""c3ef8712-88bd-415e-9d87-868c00c1e956"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""Gamepad"",
                    ""id"": ""2fa42010-8cef-427c-bd4c-d66f9ceafbd8"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Navigate"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""ef0139b1-475a-4b3b-b4b9-899ab8a44afa"",
                    ""path"": ""<Gamepad>/leftStick/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Gamepad"",
                    ""action"": ""Navigate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""up"",
                    ""id"": ""baf96401-9489-4769-a700-8cfcf27fcd42"",
                    ""path"": ""<Gamepad>/rightStick/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Gamepad"",
                    ""action"": ""Navigate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""2e4a5172-c3b1-47b2-a1bf-c10990b90574"",
                    ""path"": ""<Gamepad>/leftStick/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Gamepad"",
                    ""action"": ""Navigate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""fdfcf8c2-48e2-4eb0-b8f3-fc318eaba77b"",
                    ""path"": ""<Gamepad>/rightStick/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Gamepad"",
                    ""action"": ""Navigate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""ba71ac89-406b-45a1-a34f-1b82c90a828f"",
                    ""path"": ""<Gamepad>/leftStick/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Gamepad"",
                    ""action"": ""Navigate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""acebdaa5-a483-440c-9506-2fa25c59b498"",
                    ""path"": ""<Gamepad>/rightStick/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Gamepad"",
                    ""action"": ""Navigate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""796e2967-0d8c-48a1-80d2-616ff2df683c"",
                    ""path"": ""<Gamepad>/leftStick/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Gamepad"",
                    ""action"": ""Navigate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""d495bc95-c735-4d0d-a460-4d7ec5618c19"",
                    ""path"": ""<Gamepad>/rightStick/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Gamepad"",
                    ""action"": ""Navigate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""241aade5-8ab2-46b1-aab8-d720d30e6017"",
                    ""path"": ""<Gamepad>/dpad"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Gamepad"",
                    ""action"": ""Navigate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""Joystick"",
                    ""id"": ""d103f1c1-cad0-4bc8-8f14-d9ae59ed1511"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Navigate"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""54f4fedf-2d19-4ccd-93b7-e398f720f945"",
                    ""path"": ""<Joystick>/stick/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Joystick"",
                    ""action"": ""Navigate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""191bd310-63cc-4b68-8400-c057dc5cc05d"",
                    ""path"": ""<Joystick>/stick/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Joystick"",
                    ""action"": ""Navigate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""02b79a70-54be-4a47-b328-d643ce96f3c1"",
                    ""path"": ""<Joystick>/stick/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Joystick"",
                    ""action"": ""Navigate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""d13c0a39-213f-414f-847f-5f974bc76f29"",
                    ""path"": ""<Joystick>/stick/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Joystick"",
                    ""action"": ""Navigate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Keyboard"",
                    ""id"": ""0f3ddeb0-4030-4049-8873-70db43f5c20a"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Navigate"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""376a4793-38ca-44c4-a158-16f5333bb875"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""Navigate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""up"",
                    ""id"": ""73b8b93d-ce19-4197-9ad2-0844c7fa3203"",
                    ""path"": ""<Keyboard>/upArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""Navigate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""c11b789f-2a27-4d0d-ad56-4d720d5ab976"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""Navigate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""f0421604-ee45-40dd-9ad3-bc3f9f0184be"",
                    ""path"": ""<Keyboard>/downArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""Navigate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""af4cbfc9-c253-471b-a4bf-e39f54b7edd2"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""Navigate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""cae76636-005c-454e-b6f5-c02de594fc57"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""Navigate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""a94adbdd-b29c-4e04-828d-8f5a6c785e59"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""Navigate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""0bc30dee-917c-4ea0-815f-98f0a998cecf"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""Navigate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""5bf2f78d-49fd-4a25-88b5-e292b5662970"",
                    ""path"": ""<Keyboard>/backquote"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardMouse"",
                    ""action"": ""Toggle Console"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""bbf2f915-c3ca-4c2f-9286-d0219c42d66f"",
                    ""path"": ""<XRController>/deviceRotation"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""XR"",
                    ""action"": ""TrackedDeviceOrientation"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""98e6e9ce-96a9-4b92-aa23-e8d1d464b96e"",
                    ""path"": ""<XRController>/devicePosition"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""XR"",
                    ""action"": ""TrackedDevicePosition"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""a4e5afec-2591-4e50-8b58-2176050dd689"",
                    ""path"": ""<Mouse>/rightButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Keyboard&Mouse"",
                    ""action"": ""RightClick"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""9202b2be-fca3-4105-9205-072fdd40b50f"",
                    ""path"": ""<Mouse>/middleButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Keyboard&Mouse"",
                    ""action"": ""MiddleClick"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""16fd665f-e99a-4ffa-9f52-2f26e2715559"",
                    ""path"": ""<Mouse>/scroll"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Keyboard&Mouse"",
                    ""action"": ""ScrollWheel"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""42fe61ac-de05-4756-b645-786ba720c316"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Keyboard&Mouse"",
                    ""action"": ""Click"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""90617474-70cf-48e7-a388-fdd8825ce3e7"",
                    ""path"": ""<Pen>/tip"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Keyboard&Mouse"",
                    ""action"": ""Click"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""31035e15-fc13-48ed-a33e-50159e6e4d10"",
                    ""path"": ""<Touchscreen>/touch*/press"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Touch"",
                    ""action"": ""Click"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""80c8dbc0-328f-4f39-8bb7-d73d103e5b89"",
                    ""path"": ""<XRController>/trigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""XR"",
                    ""action"": ""Click"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""997249c9-a5f0-4686-ba4e-e593a5761a54"",
                    ""path"": ""<Mouse>/position"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""Point"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""f67ec7e9-a595-49bd-9b33-cdf720a494ed"",
                    ""path"": ""<Pen>/position"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""Point"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""24e49f8c-e10a-4689-91d9-8417778fc8bf"",
                    ""path"": ""<Touchscreen>/touch*/position"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Touch"",
                    ""action"": ""Point"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""3542ed58-4a21-47f2-be60-cb610fbc50c9"",
                    ""path"": ""*/{Cancel}"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Cancel"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""cdae4b63-6680-4808-8b46-d064b7f0d961"",
                    ""path"": ""*/{Submit}"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Submit"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""aea7c8d6-a672-499e-ae85-e7e74d669a52"",
                    ""path"": ""<Keyboard>/tab"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardMouse"",
                    ""action"": ""Select Input Field"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""KeyboardMouse"",
            ""bindingGroup"": ""KeyboardMouse"",
            ""devices"": [
                {
                    ""devicePath"": ""<Keyboard>"",
                    ""isOptional"": false,
                    ""isOR"": false
                },
                {
                    ""devicePath"": ""<Mouse>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        },
        {
            ""name"": ""XR"",
            ""bindingGroup"": ""XR"",
            ""devices"": [
                {
                    ""devicePath"": ""<XRController>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        },
        {
            ""name"": ""Touch"",
            ""bindingGroup"": ""Touch"",
            ""devices"": [
                {
                    ""devicePath"": ""<Touchscreen>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        },
        {
            ""name"": ""Joystock"",
            ""bindingGroup"": ""Joystock"",
            ""devices"": [
                {
                    ""devicePath"": ""<Joystick>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        },
        {
            ""name"": ""Gamepad"",
            ""bindingGroup"": ""Gamepad"",
            ""devices"": [
                {
                    ""devicePath"": ""<Gamepad>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        }
    ]
}");
            // Debug
            m_Debug = asset.FindActionMap("Debug", throwIfNotFound: true);
            m_Debug_Navigate = m_Debug.FindAction("Navigate", throwIfNotFound: true);
            m_Debug_Submit = m_Debug.FindAction("Submit", throwIfNotFound: true);
            m_Debug_Cancel = m_Debug.FindAction("Cancel", throwIfNotFound: true);
            m_Debug_Point = m_Debug.FindAction("Point", throwIfNotFound: true);
            m_Debug_Click = m_Debug.FindAction("Click", throwIfNotFound: true);
            m_Debug_ScrollWheel = m_Debug.FindAction("ScrollWheel", throwIfNotFound: true);
            m_Debug_MiddleClick = m_Debug.FindAction("MiddleClick", throwIfNotFound: true);
            m_Debug_RightClick = m_Debug.FindAction("RightClick", throwIfNotFound: true);
            m_Debug_TrackedDevicePosition = m_Debug.FindAction("TrackedDevicePosition", throwIfNotFound: true);
            m_Debug_TrackedDeviceOrientation = m_Debug.FindAction("TrackedDeviceOrientation", throwIfNotFound: true);
            m_Debug_ToggleConsole = m_Debug.FindAction("Toggle Console", throwIfNotFound: true);
            m_Debug_SelectInputField = m_Debug.FindAction("Select Input Field", throwIfNotFound: true);
        }

        public void Dispose()
        {
            UnityEngine.Object.Destroy(asset);
        }

        public InputBinding? bindingMask
        {
            get => asset.bindingMask;
            set => asset.bindingMask = value;
        }

        public ReadOnlyArray<InputDevice>? devices
        {
            get => asset.devices;
            set => asset.devices = value;
        }

        public ReadOnlyArray<InputControlScheme> controlSchemes => asset.controlSchemes;

        public bool Contains(InputAction action)
        {
            return asset.Contains(action);
        }

        public IEnumerator<InputAction> GetEnumerator()
        {
            return asset.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public void Enable()
        {
            asset.Enable();
        }

        public void Disable()
        {
            asset.Disable();
        }

        // Debug
        private readonly InputActionMap m_Debug;
        private IDebugActions m_DebugActionsCallbackInterface;
        private readonly InputAction m_Debug_Navigate;
        private readonly InputAction m_Debug_Submit;
        private readonly InputAction m_Debug_Cancel;
        private readonly InputAction m_Debug_Point;
        private readonly InputAction m_Debug_Click;
        private readonly InputAction m_Debug_ScrollWheel;
        private readonly InputAction m_Debug_MiddleClick;
        private readonly InputAction m_Debug_RightClick;
        private readonly InputAction m_Debug_TrackedDevicePosition;
        private readonly InputAction m_Debug_TrackedDeviceOrientation;
        private readonly InputAction m_Debug_ToggleConsole;
        private readonly InputAction m_Debug_SelectInputField;
        public struct DebugActions
        {
            private @DebugInputActions m_Wrapper;
            public DebugActions(@DebugInputActions wrapper) { m_Wrapper = wrapper; }
            public InputAction @Navigate => m_Wrapper.m_Debug_Navigate;
            public InputAction @Submit => m_Wrapper.m_Debug_Submit;
            public InputAction @Cancel => m_Wrapper.m_Debug_Cancel;
            public InputAction @Point => m_Wrapper.m_Debug_Point;
            public InputAction @Click => m_Wrapper.m_Debug_Click;
            public InputAction @ScrollWheel => m_Wrapper.m_Debug_ScrollWheel;
            public InputAction @MiddleClick => m_Wrapper.m_Debug_MiddleClick;
            public InputAction @RightClick => m_Wrapper.m_Debug_RightClick;
            public InputAction @TrackedDevicePosition => m_Wrapper.m_Debug_TrackedDevicePosition;
            public InputAction @TrackedDeviceOrientation => m_Wrapper.m_Debug_TrackedDeviceOrientation;
            public InputAction @ToggleConsole => m_Wrapper.m_Debug_ToggleConsole;
            public InputAction @SelectInputField => m_Wrapper.m_Debug_SelectInputField;
            public InputActionMap Get() { return m_Wrapper.m_Debug; }
            public void Enable() { Get().Enable(); }
            public void Disable() { Get().Disable(); }
            public bool enabled => Get().enabled;
            public static implicit operator InputActionMap(DebugActions set) { return set.Get(); }
            public void SetCallbacks(IDebugActions instance)
            {
                if (m_Wrapper.m_DebugActionsCallbackInterface != null)
                {
                    @Navigate.started -= m_Wrapper.m_DebugActionsCallbackInterface.OnNavigate;
                    @Navigate.performed -= m_Wrapper.m_DebugActionsCallbackInterface.OnNavigate;
                    @Navigate.canceled -= m_Wrapper.m_DebugActionsCallbackInterface.OnNavigate;
                    @Submit.started -= m_Wrapper.m_DebugActionsCallbackInterface.OnSubmit;
                    @Submit.performed -= m_Wrapper.m_DebugActionsCallbackInterface.OnSubmit;
                    @Submit.canceled -= m_Wrapper.m_DebugActionsCallbackInterface.OnSubmit;
                    @Cancel.started -= m_Wrapper.m_DebugActionsCallbackInterface.OnCancel;
                    @Cancel.performed -= m_Wrapper.m_DebugActionsCallbackInterface.OnCancel;
                    @Cancel.canceled -= m_Wrapper.m_DebugActionsCallbackInterface.OnCancel;
                    @Point.started -= m_Wrapper.m_DebugActionsCallbackInterface.OnPoint;
                    @Point.performed -= m_Wrapper.m_DebugActionsCallbackInterface.OnPoint;
                    @Point.canceled -= m_Wrapper.m_DebugActionsCallbackInterface.OnPoint;
                    @Click.started -= m_Wrapper.m_DebugActionsCallbackInterface.OnClick;
                    @Click.performed -= m_Wrapper.m_DebugActionsCallbackInterface.OnClick;
                    @Click.canceled -= m_Wrapper.m_DebugActionsCallbackInterface.OnClick;
                    @ScrollWheel.started -= m_Wrapper.m_DebugActionsCallbackInterface.OnScrollWheel;
                    @ScrollWheel.performed -= m_Wrapper.m_DebugActionsCallbackInterface.OnScrollWheel;
                    @ScrollWheel.canceled -= m_Wrapper.m_DebugActionsCallbackInterface.OnScrollWheel;
                    @MiddleClick.started -= m_Wrapper.m_DebugActionsCallbackInterface.OnMiddleClick;
                    @MiddleClick.performed -= m_Wrapper.m_DebugActionsCallbackInterface.OnMiddleClick;
                    @MiddleClick.canceled -= m_Wrapper.m_DebugActionsCallbackInterface.OnMiddleClick;
                    @RightClick.started -= m_Wrapper.m_DebugActionsCallbackInterface.OnRightClick;
                    @RightClick.performed -= m_Wrapper.m_DebugActionsCallbackInterface.OnRightClick;
                    @RightClick.canceled -= m_Wrapper.m_DebugActionsCallbackInterface.OnRightClick;
                    @TrackedDevicePosition.started -= m_Wrapper.m_DebugActionsCallbackInterface.OnTrackedDevicePosition;
                    @TrackedDevicePosition.performed -= m_Wrapper.m_DebugActionsCallbackInterface.OnTrackedDevicePosition;
                    @TrackedDevicePosition.canceled -= m_Wrapper.m_DebugActionsCallbackInterface.OnTrackedDevicePosition;
                    @TrackedDeviceOrientation.started -= m_Wrapper.m_DebugActionsCallbackInterface.OnTrackedDeviceOrientation;
                    @TrackedDeviceOrientation.performed -= m_Wrapper.m_DebugActionsCallbackInterface.OnTrackedDeviceOrientation;
                    @TrackedDeviceOrientation.canceled -= m_Wrapper.m_DebugActionsCallbackInterface.OnTrackedDeviceOrientation;
                    @ToggleConsole.started -= m_Wrapper.m_DebugActionsCallbackInterface.OnToggleConsole;
                    @ToggleConsole.performed -= m_Wrapper.m_DebugActionsCallbackInterface.OnToggleConsole;
                    @ToggleConsole.canceled -= m_Wrapper.m_DebugActionsCallbackInterface.OnToggleConsole;
                    @SelectInputField.started -= m_Wrapper.m_DebugActionsCallbackInterface.OnSelectInputField;
                    @SelectInputField.performed -= m_Wrapper.m_DebugActionsCallbackInterface.OnSelectInputField;
                    @SelectInputField.canceled -= m_Wrapper.m_DebugActionsCallbackInterface.OnSelectInputField;
                }
                m_Wrapper.m_DebugActionsCallbackInterface = instance;
                if (instance != null)
                {
                    @Navigate.started += instance.OnNavigate;
                    @Navigate.performed += instance.OnNavigate;
                    @Navigate.canceled += instance.OnNavigate;
                    @Submit.started += instance.OnSubmit;
                    @Submit.performed += instance.OnSubmit;
                    @Submit.canceled += instance.OnSubmit;
                    @Cancel.started += instance.OnCancel;
                    @Cancel.performed += instance.OnCancel;
                    @Cancel.canceled += instance.OnCancel;
                    @Point.started += instance.OnPoint;
                    @Point.performed += instance.OnPoint;
                    @Point.canceled += instance.OnPoint;
                    @Click.started += instance.OnClick;
                    @Click.performed += instance.OnClick;
                    @Click.canceled += instance.OnClick;
                    @ScrollWheel.started += instance.OnScrollWheel;
                    @ScrollWheel.performed += instance.OnScrollWheel;
                    @ScrollWheel.canceled += instance.OnScrollWheel;
                    @MiddleClick.started += instance.OnMiddleClick;
                    @MiddleClick.performed += instance.OnMiddleClick;
                    @MiddleClick.canceled += instance.OnMiddleClick;
                    @RightClick.started += instance.OnRightClick;
                    @RightClick.performed += instance.OnRightClick;
                    @RightClick.canceled += instance.OnRightClick;
                    @TrackedDevicePosition.started += instance.OnTrackedDevicePosition;
                    @TrackedDevicePosition.performed += instance.OnTrackedDevicePosition;
                    @TrackedDevicePosition.canceled += instance.OnTrackedDevicePosition;
                    @TrackedDeviceOrientation.started += instance.OnTrackedDeviceOrientation;
                    @TrackedDeviceOrientation.performed += instance.OnTrackedDeviceOrientation;
                    @TrackedDeviceOrientation.canceled += instance.OnTrackedDeviceOrientation;
                    @ToggleConsole.started += instance.OnToggleConsole;
                    @ToggleConsole.performed += instance.OnToggleConsole;
                    @ToggleConsole.canceled += instance.OnToggleConsole;
                    @SelectInputField.started += instance.OnSelectInputField;
                    @SelectInputField.performed += instance.OnSelectInputField;
                    @SelectInputField.canceled += instance.OnSelectInputField;
                }
            }
        }
        public DebugActions @Debug => new DebugActions(this);
        private int m_KeyboardMouseSchemeIndex = -1;
        public InputControlScheme KeyboardMouseScheme
        {
            get
            {
                if (m_KeyboardMouseSchemeIndex == -1) m_KeyboardMouseSchemeIndex = asset.FindControlSchemeIndex("KeyboardMouse");
                return asset.controlSchemes[m_KeyboardMouseSchemeIndex];
            }
        }
        private int m_XRSchemeIndex = -1;
        public InputControlScheme XRScheme
        {
            get
            {
                if (m_XRSchemeIndex == -1) m_XRSchemeIndex = asset.FindControlSchemeIndex("XR");
                return asset.controlSchemes[m_XRSchemeIndex];
            }
        }
        private int m_TouchSchemeIndex = -1;
        public InputControlScheme TouchScheme
        {
            get
            {
                if (m_TouchSchemeIndex == -1) m_TouchSchemeIndex = asset.FindControlSchemeIndex("Touch");
                return asset.controlSchemes[m_TouchSchemeIndex];
            }
        }
        private int m_JoystockSchemeIndex = -1;
        public InputControlScheme JoystockScheme
        {
            get
            {
                if (m_JoystockSchemeIndex == -1) m_JoystockSchemeIndex = asset.FindControlSchemeIndex("Joystock");
                return asset.controlSchemes[m_JoystockSchemeIndex];
            }
        }
        private int m_GamepadSchemeIndex = -1;
        public InputControlScheme GamepadScheme
        {
            get
            {
                if (m_GamepadSchemeIndex == -1) m_GamepadSchemeIndex = asset.FindControlSchemeIndex("Gamepad");
                return asset.controlSchemes[m_GamepadSchemeIndex];
            }
        }
        public interface IDebugActions
        {
            void OnNavigate(InputAction.CallbackContext context);
            void OnSubmit(InputAction.CallbackContext context);
            void OnCancel(InputAction.CallbackContext context);
            void OnPoint(InputAction.CallbackContext context);
            void OnClick(InputAction.CallbackContext context);
            void OnScrollWheel(InputAction.CallbackContext context);
            void OnMiddleClick(InputAction.CallbackContext context);
            void OnRightClick(InputAction.CallbackContext context);
            void OnTrackedDevicePosition(InputAction.CallbackContext context);
            void OnTrackedDeviceOrientation(InputAction.CallbackContext context);
            void OnToggleConsole(InputAction.CallbackContext context);
            void OnSelectInputField(InputAction.CallbackContext context);
        }
    }
}
