import React, { createContext, useState, useContext } from 'react';

const ModalContext = createContext();

export const useModal = () => useContext(ModalContext);

export const ModalProvider = ({ children }) => {
    const [isCreateModalVisible, setIsCreateModalVisible] = useState(false);

    const [isViewEditModalVisible, setIsViewEditModalVisible] = useState(false);
    const [viewEditModalProductId, setViewEditModalProductId] = useState(null);

    return (
        <ModalContext.Provider value={{
            isCreateModalVisible,
            setIsCreateModalVisible,

            isViewEditModalVisible,
            setIsViewEditModalVisible,
            viewEditModalProductId,
            setViewEditModalProductId,
        }}>
            {children}
        </ModalContext.Provider>
    );
}