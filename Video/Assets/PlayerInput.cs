//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.7.0
//     from Assets/PlayerInput.inputactions
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public partial class @PlayerInput: IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @PlayerInput()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerInput"",
    ""maps"": [
        {
            ""name"": ""BasicMovement"",
            ""id"": ""2bcc548f-3d4d-4855-b688-ef56050e43a8"",
            ""actions"": [
                {
                    ""name"": ""MoveDirection"",
                    ""type"": ""Value"",
                    ""id"": ""ecf9b3ab-8a49-41f7-be7a-f0bc0aa50fc5"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Spin"",
                    ""type"": ""Button"",
                    ""id"": ""8ee67ca5-b1af-4bfb-b742-00bd0bf02fec"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""WASD"",
                    ""id"": ""8a5e826f-928f-4bd9-b554-fcfbaf65dd80"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveDirection"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""78274c26-7f9f-42b8-98fa-27e7dde5f454"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveDirection"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""e69dc260-4989-45d8-9215-639240cd60d7"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveDirection"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""223b5345-ca0b-4a4e-84c3-3effe4fdf6b2"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveDirection"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""08c28f80-2d4f-48b3-a03c-f224f6d6aa17"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveDirection"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""cc0bcf98-faef-4644-ac9a-06ed038f32b3"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Spin"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // BasicMovement
        m_BasicMovement = asset.FindActionMap("BasicMovement", throwIfNotFound: true);
        m_BasicMovement_MoveDirection = m_BasicMovement.FindAction("MoveDirection", throwIfNotFound: true);
        m_BasicMovement_Spin = m_BasicMovement.FindAction("Spin", throwIfNotFound: true);
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

    public IEnumerable<InputBinding> bindings => asset.bindings;

    public InputAction FindAction(string actionNameOrId, bool throwIfNotFound = false)
    {
        return asset.FindAction(actionNameOrId, throwIfNotFound);
    }

    public int FindBinding(InputBinding bindingMask, out InputAction action)
    {
        return asset.FindBinding(bindingMask, out action);
    }

    // BasicMovement
    private readonly InputActionMap m_BasicMovement;
    private List<IBasicMovementActions> m_BasicMovementActionsCallbackInterfaces = new List<IBasicMovementActions>();
    private readonly InputAction m_BasicMovement_MoveDirection;
    private readonly InputAction m_BasicMovement_Spin;
    public struct BasicMovementActions
    {
        private @PlayerInput m_Wrapper;
        public BasicMovementActions(@PlayerInput wrapper) { m_Wrapper = wrapper; }
        public InputAction @MoveDirection => m_Wrapper.m_BasicMovement_MoveDirection;
        public InputAction @Spin => m_Wrapper.m_BasicMovement_Spin;
        public InputActionMap Get() { return m_Wrapper.m_BasicMovement; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(BasicMovementActions set) { return set.Get(); }
        public void AddCallbacks(IBasicMovementActions instance)
        {
            if (instance == null || m_Wrapper.m_BasicMovementActionsCallbackInterfaces.Contains(instance)) return;
            m_Wrapper.m_BasicMovementActionsCallbackInterfaces.Add(instance);
            @MoveDirection.started += instance.OnMoveDirection;
            @MoveDirection.performed += instance.OnMoveDirection;
            @MoveDirection.canceled += instance.OnMoveDirection;
            @Spin.started += instance.OnSpin;
            @Spin.performed += instance.OnSpin;
            @Spin.canceled += instance.OnSpin;
        }

        private void UnregisterCallbacks(IBasicMovementActions instance)
        {
            @MoveDirection.started -= instance.OnMoveDirection;
            @MoveDirection.performed -= instance.OnMoveDirection;
            @MoveDirection.canceled -= instance.OnMoveDirection;
            @Spin.started -= instance.OnSpin;
            @Spin.performed -= instance.OnSpin;
            @Spin.canceled -= instance.OnSpin;
        }

        public void RemoveCallbacks(IBasicMovementActions instance)
        {
            if (m_Wrapper.m_BasicMovementActionsCallbackInterfaces.Remove(instance))
                UnregisterCallbacks(instance);
        }

        public void SetCallbacks(IBasicMovementActions instance)
        {
            foreach (var item in m_Wrapper.m_BasicMovementActionsCallbackInterfaces)
                UnregisterCallbacks(item);
            m_Wrapper.m_BasicMovementActionsCallbackInterfaces.Clear();
            AddCallbacks(instance);
        }
    }
    public BasicMovementActions @BasicMovement => new BasicMovementActions(this);
    public interface IBasicMovementActions
    {
        void OnMoveDirection(InputAction.CallbackContext context);
        void OnSpin(InputAction.CallbackContext context);
    }
}
