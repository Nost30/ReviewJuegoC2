using System;
using System.ComponentModel;
using System.Diagnostics;

namespace ReviewsJuegos.My
{
    internal static partial class MyProject
    {
        internal partial class MyForms
        {

            [EditorBrowsable(EditorBrowsableState.Never)]
            public AgregarDesarrolladora m_AgregarDesarrolladora;

            public AgregarDesarrolladora AgregarDesarrolladora
            {
                [DebuggerHidden]
                get
                {
                    m_AgregarDesarrolladora = Create__Instance__(m_AgregarDesarrolladora);
                    return m_AgregarDesarrolladora;
                }
                [DebuggerHidden]
                set
                {
                    if (ReferenceEquals(value, m_AgregarDesarrolladora))
                        return;
                    if (value is not null)
                        throw new ArgumentException("Property can only be set to Nothing");
                    Dispose__Instance__(ref m_AgregarDesarrolladora);
                }
            }


            [EditorBrowsable(EditorBrowsableState.Never)]
            public AgregarGenero m_AgregarGenero;

            public AgregarGenero AgregarGenero
            {
                [DebuggerHidden]
                get
                {
                    m_AgregarGenero = Create__Instance__(m_AgregarGenero);
                    return m_AgregarGenero;
                }
                [DebuggerHidden]
                set
                {
                    if (ReferenceEquals(value, m_AgregarGenero))
                        return;
                    if (value is not null)
                        throw new ArgumentException("Property can only be set to Nothing");
                    Dispose__Instance__(ref m_AgregarGenero);
                }
            }


            [EditorBrowsable(EditorBrowsableState.Never)]
            public AgregarPlataforma m_AgregarPlataforma;

            public AgregarPlataforma AgregarPlataforma
            {
                [DebuggerHidden]
                get
                {
                    m_AgregarPlataforma = Create__Instance__(m_AgregarPlataforma);
                    return m_AgregarPlataforma;
                }
                [DebuggerHidden]
                set
                {
                    if (ReferenceEquals(value, m_AgregarPlataforma))
                        return;
                    if (value is not null)
                        throw new ArgumentException("Property can only be set to Nothing");
                    Dispose__Instance__(ref m_AgregarPlataforma);
                }
            }


            [EditorBrowsable(EditorBrowsableState.Never)]
            public Form1 m_Form1;

            public Form1 Form1
            {
                [DebuggerHidden]
                get
                {
                    m_Form1 = Create__Instance__(m_Form1);
                    return m_Form1;
                }
                [DebuggerHidden]
                set
                {
                    if (ReferenceEquals(value, m_Form1))
                        return;
                    if (value is not null)
                        throw new ArgumentException("Property can only be set to Nothing");
                    Dispose__Instance__(ref m_Form1);
                }
            }


            [EditorBrowsable(EditorBrowsableState.Never)]
            public FormularioActualizar m_FormularioActualizar;

            public FormularioActualizar FormularioActualizar
            {
                [DebuggerHidden]
                get
                {
                    m_FormularioActualizar = Create__Instance__(m_FormularioActualizar);
                    return m_FormularioActualizar;
                }
                [DebuggerHidden]
                set
                {
                    if (ReferenceEquals(value, m_FormularioActualizar))
                        return;
                    if (value is not null)
                        throw new ArgumentException("Property can only be set to Nothing");
                    Dispose__Instance__(ref m_FormularioActualizar);
                }
            }


            [EditorBrowsable(EditorBrowsableState.Never)]
            public FormularioAgregar m_FormularioAgregar;

            public FormularioAgregar FormularioAgregar
            {
                [DebuggerHidden]
                get
                {
                    m_FormularioAgregar = Create__Instance__(m_FormularioAgregar);
                    return m_FormularioAgregar;
                }
                [DebuggerHidden]
                set
                {
                    if (ReferenceEquals(value, m_FormularioAgregar))
                        return;
                    if (value is not null)
                        throw new ArgumentException("Property can only be set to Nothing");
                    Dispose__Instance__(ref m_FormularioAgregar);
                }
            }


            [EditorBrowsable(EditorBrowsableState.Never)]
            public Login m_Login;

            public Login Login
            {
                [DebuggerHidden]
                get
                {
                    m_Login = Create__Instance__(m_Login);
                    return m_Login;
                }
                [DebuggerHidden]
                set
                {
                    if (ReferenceEquals(value, m_Login))
                        return;
                    if (value is not null)
                        throw new ArgumentException("Property can only be set to Nothing");
                    Dispose__Instance__(ref m_Login);
                }
            }

        }


    }
}