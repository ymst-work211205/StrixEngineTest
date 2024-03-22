// GENERATED AUTOMATICALLY FROM 'Assets/InputSystem/SampleControls.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @SampleControls : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @SampleControls()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""SampleControls"",
    ""maps"": [
        {
            ""name"": ""PlayerControl"",
            ""id"": ""c1748afe-d194-4970-bed1-c6f1b06e075d"",
            ""actions"": [
                {
                    ""name"": ""Move"",
                    ""type"": ""Value"",
                    ""id"": ""d4f664fa-9c42-49c8-b31f-2cd83938bbac"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Rest"",
                    ""type"": ""Button"",
                    ""id"": ""451e124a-cb19-4da4-a0e4-eccad93cb269"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Shoot"",
                    ""type"": ""Button"",
                    ""id"": ""a1bf6161-3b7c-4238-80e1-ec3781716ec8"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""e7f22f43-587b-4cfa-a6a4-50bcac8f93b2"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""7b499dde-dfcc-45f9-8090-08e3598f0e85"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""a158d1f8-1844-4749-8eea-4e41cf39e359"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""4a66f3b3-3ef9-4eca-90bd-8aafbcaebb9e"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""a38cc7d3-face-4c1f-9c86-22fc4fb4ce8d"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""5832c96e-4738-456e-b913-cf0e80212529"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Rest"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""9cd2d25b-cc1f-4de5-8640-c3334e3e6481"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Shoot"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""CameraControl"",
            ""id"": ""1d7552ad-96bf-486d-9934-99b189cf9938"",
            ""actions"": [
                {
                    ""name"": ""Drag"",
                    ""type"": ""Value"",
                    ""id"": ""a9f308fb-0396-457b-a1d0-25b86e628fd6"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""b4ac4be5-9868-4359-9ab1-56f2733c42f8"",
                    ""path"": ""<Mouse>/delta"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Drag"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""Arrow"",
                    ""id"": ""e147a7d4-7dad-4944-8af1-d3abc8582177"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Drag"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""ebfea491-1abe-475d-a24f-f7ef69c36c06"",
                    ""path"": ""<Keyboard>/upArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Drag"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""27e3bdff-88a9-4fd3-b44a-ee58c504eb33"",
                    ""path"": ""<Keyboard>/downArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Drag"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""973b445a-19bc-49c8-a759-d30c88d6e63c"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Drag"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""be211f06-6462-42f9-9732-a38b8653cdf6"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Drag"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                }
            ]
        },
        {
            ""name"": ""Common"",
            ""id"": ""bbae6ecf-9839-4f6e-9129-552e26dc1142"",
            ""actions"": [
                {
                    ""name"": ""ExitGame"",
                    ""type"": ""Button"",
                    ""id"": ""f3cb2853-de9c-4171-aa0d-463695a9be53"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""EscapeCursor"",
                    ""type"": ""Button"",
                    ""id"": ""95424d18-0902-4449-8b03-bc0a7eeab8e2"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""3a694f7e-60ac-485d-884b-b4a0a4b2784e"",
                    ""path"": ""<Keyboard>/escape"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ExitGame"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""8d0fcd96-3d68-4a83-8df7-bb6b0dec9717"",
                    ""path"": ""<Keyboard>/leftAlt"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""EscapeCursor"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""Chat"",
            ""id"": ""de9c9588-c1c6-4724-a906-5c8fbb1a82e1"",
            ""actions"": [
                {
                    ""name"": ""EnterChat"",
                    ""type"": ""Button"",
                    ""id"": ""2cee8d7d-9104-4c83-a0e3-a8847eb8cf41"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""SendChat"",
                    ""type"": ""Button"",
                    ""id"": ""8da17462-d57d-45af-a303-38888dc1cb31"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""bfbf4135-d776-46ff-803b-df51f20d14c8"",
                    ""path"": ""<Keyboard>/enter"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""EnterChat"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""78b804d6-e7aa-4672-8da0-7337e1d1e29c"",
                    ""path"": ""<Keyboard>/enter"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""SendChat"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // PlayerControl
        m_PlayerControl = asset.FindActionMap("PlayerControl", throwIfNotFound: true);
        m_PlayerControl_Move = m_PlayerControl.FindAction("Move", throwIfNotFound: true);
        m_PlayerControl_Rest = m_PlayerControl.FindAction("Rest", throwIfNotFound: true);
        m_PlayerControl_Shoot = m_PlayerControl.FindAction("Shoot", throwIfNotFound: true);
        // CameraControl
        m_CameraControl = asset.FindActionMap("CameraControl", throwIfNotFound: true);
        m_CameraControl_Drag = m_CameraControl.FindAction("Drag", throwIfNotFound: true);
        // Common
        m_Common = asset.FindActionMap("Common", throwIfNotFound: true);
        m_Common_ExitGame = m_Common.FindAction("ExitGame", throwIfNotFound: true);
        m_Common_EscapeCursor = m_Common.FindAction("EscapeCursor", throwIfNotFound: true);
        // Chat
        m_Chat = asset.FindActionMap("Chat", throwIfNotFound: true);
        m_Chat_EnterChat = m_Chat.FindAction("EnterChat", throwIfNotFound: true);
        m_Chat_SendChat = m_Chat.FindAction("SendChat", throwIfNotFound: true);
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

    // PlayerControl
    private readonly InputActionMap m_PlayerControl;
    private IPlayerControlActions m_PlayerControlActionsCallbackInterface;
    private readonly InputAction m_PlayerControl_Move;
    private readonly InputAction m_PlayerControl_Rest;
    private readonly InputAction m_PlayerControl_Shoot;
    public struct PlayerControlActions
    {
        private @SampleControls m_Wrapper;
        public PlayerControlActions(@SampleControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Move => m_Wrapper.m_PlayerControl_Move;
        public InputAction @Rest => m_Wrapper.m_PlayerControl_Rest;
        public InputAction @Shoot => m_Wrapper.m_PlayerControl_Shoot;
        public InputActionMap Get() { return m_Wrapper.m_PlayerControl; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PlayerControlActions set) { return set.Get(); }
        public void SetCallbacks(IPlayerControlActions instance)
        {
            if (m_Wrapper.m_PlayerControlActionsCallbackInterface != null)
            {
                @Move.started -= m_Wrapper.m_PlayerControlActionsCallbackInterface.OnMove;
                @Move.performed -= m_Wrapper.m_PlayerControlActionsCallbackInterface.OnMove;
                @Move.canceled -= m_Wrapper.m_PlayerControlActionsCallbackInterface.OnMove;
                @Rest.started -= m_Wrapper.m_PlayerControlActionsCallbackInterface.OnRest;
                @Rest.performed -= m_Wrapper.m_PlayerControlActionsCallbackInterface.OnRest;
                @Rest.canceled -= m_Wrapper.m_PlayerControlActionsCallbackInterface.OnRest;
                @Shoot.started -= m_Wrapper.m_PlayerControlActionsCallbackInterface.OnShoot;
                @Shoot.performed -= m_Wrapper.m_PlayerControlActionsCallbackInterface.OnShoot;
                @Shoot.canceled -= m_Wrapper.m_PlayerControlActionsCallbackInterface.OnShoot;
            }
            m_Wrapper.m_PlayerControlActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Move.started += instance.OnMove;
                @Move.performed += instance.OnMove;
                @Move.canceled += instance.OnMove;
                @Rest.started += instance.OnRest;
                @Rest.performed += instance.OnRest;
                @Rest.canceled += instance.OnRest;
                @Shoot.started += instance.OnShoot;
                @Shoot.performed += instance.OnShoot;
                @Shoot.canceled += instance.OnShoot;
            }
        }
    }
    public PlayerControlActions @PlayerControl => new PlayerControlActions(this);

    // CameraControl
    private readonly InputActionMap m_CameraControl;
    private ICameraControlActions m_CameraControlActionsCallbackInterface;
    private readonly InputAction m_CameraControl_Drag;
    public struct CameraControlActions
    {
        private @SampleControls m_Wrapper;
        public CameraControlActions(@SampleControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Drag => m_Wrapper.m_CameraControl_Drag;
        public InputActionMap Get() { return m_Wrapper.m_CameraControl; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(CameraControlActions set) { return set.Get(); }
        public void SetCallbacks(ICameraControlActions instance)
        {
            if (m_Wrapper.m_CameraControlActionsCallbackInterface != null)
            {
                @Drag.started -= m_Wrapper.m_CameraControlActionsCallbackInterface.OnDrag;
                @Drag.performed -= m_Wrapper.m_CameraControlActionsCallbackInterface.OnDrag;
                @Drag.canceled -= m_Wrapper.m_CameraControlActionsCallbackInterface.OnDrag;
            }
            m_Wrapper.m_CameraControlActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Drag.started += instance.OnDrag;
                @Drag.performed += instance.OnDrag;
                @Drag.canceled += instance.OnDrag;
            }
        }
    }
    public CameraControlActions @CameraControl => new CameraControlActions(this);

    // Common
    private readonly InputActionMap m_Common;
    private ICommonActions m_CommonActionsCallbackInterface;
    private readonly InputAction m_Common_ExitGame;
    private readonly InputAction m_Common_EscapeCursor;
    public struct CommonActions
    {
        private @SampleControls m_Wrapper;
        public CommonActions(@SampleControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @ExitGame => m_Wrapper.m_Common_ExitGame;
        public InputAction @EscapeCursor => m_Wrapper.m_Common_EscapeCursor;
        public InputActionMap Get() { return m_Wrapper.m_Common; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(CommonActions set) { return set.Get(); }
        public void SetCallbacks(ICommonActions instance)
        {
            if (m_Wrapper.m_CommonActionsCallbackInterface != null)
            {
                @ExitGame.started -= m_Wrapper.m_CommonActionsCallbackInterface.OnExitGame;
                @ExitGame.performed -= m_Wrapper.m_CommonActionsCallbackInterface.OnExitGame;
                @ExitGame.canceled -= m_Wrapper.m_CommonActionsCallbackInterface.OnExitGame;
                @EscapeCursor.started -= m_Wrapper.m_CommonActionsCallbackInterface.OnEscapeCursor;
                @EscapeCursor.performed -= m_Wrapper.m_CommonActionsCallbackInterface.OnEscapeCursor;
                @EscapeCursor.canceled -= m_Wrapper.m_CommonActionsCallbackInterface.OnEscapeCursor;
            }
            m_Wrapper.m_CommonActionsCallbackInterface = instance;
            if (instance != null)
            {
                @ExitGame.started += instance.OnExitGame;
                @ExitGame.performed += instance.OnExitGame;
                @ExitGame.canceled += instance.OnExitGame;
                @EscapeCursor.started += instance.OnEscapeCursor;
                @EscapeCursor.performed += instance.OnEscapeCursor;
                @EscapeCursor.canceled += instance.OnEscapeCursor;
            }
        }
    }
    public CommonActions @Common => new CommonActions(this);

    // Chat
    private readonly InputActionMap m_Chat;
    private IChatActions m_ChatActionsCallbackInterface;
    private readonly InputAction m_Chat_EnterChat;
    private readonly InputAction m_Chat_SendChat;
    public struct ChatActions
    {
        private @SampleControls m_Wrapper;
        public ChatActions(@SampleControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @EnterChat => m_Wrapper.m_Chat_EnterChat;
        public InputAction @SendChat => m_Wrapper.m_Chat_SendChat;
        public InputActionMap Get() { return m_Wrapper.m_Chat; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(ChatActions set) { return set.Get(); }
        public void SetCallbacks(IChatActions instance)
        {
            if (m_Wrapper.m_ChatActionsCallbackInterface != null)
            {
                @EnterChat.started -= m_Wrapper.m_ChatActionsCallbackInterface.OnEnterChat;
                @EnterChat.performed -= m_Wrapper.m_ChatActionsCallbackInterface.OnEnterChat;
                @EnterChat.canceled -= m_Wrapper.m_ChatActionsCallbackInterface.OnEnterChat;
                @SendChat.started -= m_Wrapper.m_ChatActionsCallbackInterface.OnSendChat;
                @SendChat.performed -= m_Wrapper.m_ChatActionsCallbackInterface.OnSendChat;
                @SendChat.canceled -= m_Wrapper.m_ChatActionsCallbackInterface.OnSendChat;
            }
            m_Wrapper.m_ChatActionsCallbackInterface = instance;
            if (instance != null)
            {
                @EnterChat.started += instance.OnEnterChat;
                @EnterChat.performed += instance.OnEnterChat;
                @EnterChat.canceled += instance.OnEnterChat;
                @SendChat.started += instance.OnSendChat;
                @SendChat.performed += instance.OnSendChat;
                @SendChat.canceled += instance.OnSendChat;
            }
        }
    }
    public ChatActions @Chat => new ChatActions(this);
    public interface IPlayerControlActions
    {
        void OnMove(InputAction.CallbackContext context);
        void OnRest(InputAction.CallbackContext context);
        void OnShoot(InputAction.CallbackContext context);
    }
    public interface ICameraControlActions
    {
        void OnDrag(InputAction.CallbackContext context);
    }
    public interface ICommonActions
    {
        void OnExitGame(InputAction.CallbackContext context);
        void OnEscapeCursor(InputAction.CallbackContext context);
    }
    public interface IChatActions
    {
        void OnEnterChat(InputAction.CallbackContext context);
        void OnSendChat(InputAction.CallbackContext context);
    }
}
